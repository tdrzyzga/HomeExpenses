using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Message.Response;
using Microsoft.Extensions.Logging;
using Remotion.Linq.Clauses;

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

            }
            //catch (DomainException domainException)
            //{
            //    Logger.ForContext<BaseActor>().Error(domainException, "Error occured during handling command {Command}", command);
            //    Sender.Tell(new ErrorResponse(domainException.PublicMessage));
            //}
            //catch (ApplicationException applicationException)
            //{
            //    Logger.ForContext<BaseActor>().Error(applicationException, "Error occured during handling command {Command}", command);
            //    Sender.Tell(new ErrorResponse(applicationException.PublicMessage));
            //}
            catch (Exception exception)
            {
                _logger.LogError(exception, "Error occured during handling command {Command}", command);
                Sender.Tell(new ErrorResponse("GENERAL ERROR"));
            }

            Sender.Tell(new CommandSuccessResponse());
        }
    }
}