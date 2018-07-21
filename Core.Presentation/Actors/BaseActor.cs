using System;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Message.Responses;
using Microsoft.Extensions.Logging;

namespace Core.Presentation.Actors
{
    public class BaseActor : ReceiveActor
    {
        private readonly ILogger _logger;

        public BaseActor(ILogger logger)
        {
            _logger = logger;
        }

        protected async Task HandleQuery<TQuery>(TQuery query, Func<TQuery, Task> action) where TQuery : class
        {
            try
            {
                await action(query);

                _logger.LogDebug("Query {Query} successfuly handled.", query);

                Sender.Tell(new CommandSuccessResponse());
            }

            catch (Exception exception)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(exception, "Error occured during handling command {Query}", query);

                Sender.Tell(new ErrorResponse(errorId, "GENERAL ERROR"));
            }
        }
    }
}