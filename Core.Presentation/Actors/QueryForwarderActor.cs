using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Util;
using Core.Message.Commands;
using Core.Message.Queries;
using Microsoft.Extensions.Logging;

namespace Core.Presentation.Actors
{
    public class QueryForwarderActor : ReceiveActor
    {
        private readonly List<IActorRef> _autostartedActors;
        private readonly ILogger _logger;

        public QueryForwarderActor(List<IActorRef> autostartedActors, ILogger logger)
        {
            _autostartedActors = autostartedActors;
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

            var interfaceType = typeof(IQueryActor<>).MakeGenericType(queryType);

            var actorInfo = Assembly.GetEntryAssembly().GetReferencedAssemblies().Select(Assembly.Load)
                                    .SelectMany(x => x.GetExportedTypes().Where(y => y.Implements(interfaceType)))
                                    .Select(x => new {x.Name})
                                    .SingleOrDefault();

            if (actorInfo == null)
            {
                throw new ActorNotFoundException();
            }

            var actor = _autostartedActors.Find(x => x.Path.Name == actorInfo.Name);

            if (actor == null)
            {
                throw new ActorNotFoundException();
            }

            return actor;
        }
    }
}