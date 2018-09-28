using System;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Message.Commands;
using Core.Message.Queries;
using Microsoft.Extensions.Logging;

namespace Core.Presentation.Actors
{
    public class BaseActor : ReceiveActor
    {
        private readonly ILogger _logger;

        public BaseActor(IBaseActorPayload payload)
        {
            _logger = payload.Logger;
        }

        protected async Task HandleQuery<TQuery, TResult>(TQuery query, Func<TQuery, Task<TResult>> action) 
            where TQuery : IQuery
            where TResult: IQueryResult
        {
            try
            {
                var result = await action(query);

                _logger.LogDebug("Query {Query} successfuly handled.", query);

                Sender.Tell(result);
            }

            catch (Exception exception)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(exception, "Error occured during handling command {Query}", query);

                Sender.Tell(new CommandErrorResponse(errorId, "GENERAL ERROR"));
            }
        }
    }
}