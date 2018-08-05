using System;
using System.Linq;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Domain.Exceptions;
using Core.Message.Commands;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ApplicationException = Core.Application.Exceptions.ApplicationException;

namespace Core.Application.Actors
{
    public class BaseActor : ReceiveActor
    {
        private readonly ILogger _logger;
        private readonly IServiceProvider _serviceProvider;

        protected BaseActor(IBaseActorPayload payload)
        {
            _logger = payload.Logger;
            _serviceProvider = payload.ServiceProvider;
        }

        protected async Task HandleCommand<TCommand>(TCommand command, Func<TCommand, Task> action) where TCommand : ICommand
        {
            try
            {
                await Validate(command);
                await action(command);

                _logger.LogDebug("Command {Command} successfuly handled.", command);

                Sender.Tell(new CommandSuccessResponse());
            }
            catch (ValidationException validationException)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(validationException, "Validation errors during handling command {Command}", command);

                Sender.Tell(new ValidationErrorResponse(errorId,
                                                     validationException.Errors.Select(x => new CommandErrorResponse.ErrorItem(x.PropertyName, x.ErrorMessage)).ToArray()));
            }
            catch (DomainException domainException)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(domainException, "Error occured during handling command {Command}", command);

                Sender.Tell(new CommandErrorResponse(errorId,
                                              domainException.PublicMessage,
                                              domainException.Errors.Select(x => new CommandErrorResponse.ErrorItem(x.Key, x.Value)).ToArray()));
            }
            catch (ApplicationException applicationException)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(applicationException, "Error occured during handling command {Command}", command);

                Sender.Tell(new CommandErrorResponse(errorId,
                                              applicationException.PublicMessage,
                                              applicationException.Errors.Select(x => new CommandErrorResponse.ErrorItem(x.Key, x.Value)).ToArray()));
            }
            catch (Exception exception)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(exception, "Error occured during handling command {Command}", command);

                Sender.Tell(new CommandErrorResponse(errorId, "GENERAL ERROR"));
            }
        }

        private async Task Validate<TCommand>(TCommand command)
        {
            var validator = _serviceProvider.GetService<IValidator<TCommand>>();
            if (validator != null)
            {
                await validator.ValidateAndThrowAsync(command);
            }
        }
    }
}