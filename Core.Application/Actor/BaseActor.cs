using System;
using System.Linq;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Domain.Exceptions;
using Core.Message.Response;
using Microsoft.Extensions.Logging;
using ApplicationException = Core.Application.Exceptions.ApplicationException;

namespace Core.Application.Actor
{
    public class BaseActor : ReceiveActor
    {
        private readonly ILogger _logger;

        public BaseActor(ILogger logger)
        {
            _logger = logger;
        }

        protected async Task HandleCommand<TCommand>(TCommand command, Func<TCommand, Task> action) where TCommand : class
        {
            try
            {
                await action(command);

                _logger.LogDebug("Command {Command} successfuly handled.", command);

                Sender.Tell(new CommandSuccessResponse());
            }
            catch (DomainException domainException)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(domainException, "Error occured during handling command {Command}", command);

                Sender.Tell(new ErrorResponse(errorId,
                                              domainException.PublicMessage,
                                              domainException.Errors.Select(x => new ErrorResponse.ErrorItem(x.Key, x.Value)).ToArray()));
            }
            catch (ApplicationException applicationException)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(applicationException, "Error occured during handling command {Command}", command);

                Sender.Tell(new ErrorResponse(errorId,
                                              applicationException.PublicMessage,
                                              applicationException.Errors.Select(x => new ErrorResponse.ErrorItem(x.Key, x.Value)).ToArray()));
            }
            catch (Exception exception)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(exception, "Error occured during handling command {Command}", command);

                Sender.Tell(new ErrorResponse(errorId, "GENERAL ERROR"));
            }
        }
    }
}