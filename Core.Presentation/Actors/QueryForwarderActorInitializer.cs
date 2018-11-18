using System;
using System.Collections.Generic;
using Akka.Actor;
using Core.Akka.ActorSystem;
using Microsoft.Extensions.Logging;

namespace Core.Presentation.Actors
{
    public class QueryForwarderActorInitializer : IQueryForwarderActorInitializer
    {
        private readonly ILocalActorSystemManager _localActorSystemManager;
        private readonly ILogger _logger;

        public QueryForwarderActorInitializer(ILocalActorSystemManager localActorSystemManager, ILogger<QueryForwarderActor> logger)
        {
            _localActorSystemManager = localActorSystemManager;
            _logger = logger;
        }

        public void StartQueryForwarderActor(Dictionary<Type, IActorRef> autostartedQueryActors)
        {
            var props = Props.Create(() => new QueryForwarderActor(autostartedQueryActors, _logger));
            _localActorSystemManager.ActorSystem.ActorOf(props, "QueryForwarderActor");
        }
    }
}