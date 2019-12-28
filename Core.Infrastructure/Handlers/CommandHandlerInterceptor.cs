using Core.Application.Handlers;
using Core.Domain.Exceptions;
using Core.Message.Commands;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using ApplicationException = Core.Application.Exceptions.ApplicationException;

namespace Core.Infrastructure.Handlers
{
    public class CommandHandlerInterceptor<TCommand> : ICommandHandlerInterceptor<TCommand> where TCommand : ICommand
    {
        private readonly ILogger<CommandHandlerInterceptor<TCommand>> _logger;
        private readonly IServiceScope _scope;

        public CommandHandlerInterceptor(IServiceProvider serviceProvider, ILogger<CommandHandlerInterceptor<TCommand>> logger)
        {
            _scope = serviceProvider.CreateScope();
            _logger = logger;
        }

        public async Task<CommandResponse> Handle(TCommand command)
        {
            try
            {
                await Validate(command);

                var handler = _scope.ServiceProvider.GetService<ICommandHandler<TCommand>>();
                await handler.Handle(command);

                _logger.LogDebug("Command {Command} successfuly handled", command);

                return new CommandSuccessResponse();
            }
            catch (ValidationException validationException)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(validationException, "Validation errors during handling command {Command}", command);

                return new ValidationErrorResponse(errorId,
                                                   validationException.Errors.Select(x => new CommandErrorResponse.ErrorItem(x.PropertyName, x.ErrorMessage)).ToArray());
            }
            catch (DomainException domainException)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(domainException, "Error occured during handling command {Command}", command);

                return new CommandErrorResponse(errorId,
                                                domainException.PublicMessage,
                                                domainException.Errors.Select(x => new CommandErrorResponse.ErrorItem(x.Key, x.Value)).ToArray());
            }
            catch (ApplicationException applicationException)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(applicationException, "Error occured during handling command {Command}", command);

                return new CommandErrorResponse(errorId,
                                                applicationException.PublicMessage,
                                                applicationException.Errors.Select(x => new CommandErrorResponse.ErrorItem(x.Key, x.Value)).ToArray());
            }
            catch (Exception exception)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(exception, "Error occured during handling command {Command}", command);

                return new CommandErrorResponse(errorId, "GENERAL ERROR");
            }
        }

        private async Task Validate(TCommand command)
        {
            var validator = _scope.ServiceProvider.GetService<IValidator<TCommand>>();
            if (validator != null)
            {
                await validator.ValidateAndThrowAsync(command);
            }
        }
    }
}