using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Message.Commands;
using Core.Message.Queries;
using Microsoft.Extensions.Logging;

namespace Core.Presentation.Actors
{
    public class QueryForwarderActor : ReceiveActor
    {
        private readonly Dictionary<Type, IActorRef> _autostartedQueryActors;
        private readonly ILogger _logger;

        public QueryForwarderActor(Dictionary<Type, IActorRef> autostartedQueryActors, ILogger logger)
        {
            _autostartedQueryActors = autostartedQueryActors;
            _logger = logger;

            ReceiveAsync<IQuery>(Handle);
        }

        private Task Handle<TQuery>(TQuery query) where TQuery : IQuery
        {
            try
            {
                var actor = GetActor(query);

                _logger.LogDebug("Query {Query} forwarding by QueryForwarderActor", query);

                actor.Forward(query);
            }
            catch (Exception exception)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(exception, "Error occured during forwarding query {query}", query);

                Sender.Tell(new CommandErrorResponse(errorId, "GENERAL ERROR"));
            }

            return Task.CompletedTask;
        }

        private IActorRef GetActor<TQuery>(TQuery query) where TQuery : IQuery
        {
            var queryType = query.GetType();

            var actorInterfaceImplementedType = typeof(IQueryActor<>).MakeGenericType(queryType);

            var actor = _autostartedQueryActors.GetValueOrDefault(actorInterfaceImplementedType);

            if (actor == null)
            {
                throw new ActorNotFoundException();
            }

            return actor;
        }
    }
}