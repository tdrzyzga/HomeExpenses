using System;
using Akka.Actor;
using Core.Akka.ActorSystem;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class QueryForwarderActorProvider
    {
        public IActorRef QueryForwarderActor { get; }

        public QueryForwarderActorProvider(ILocalActorSystemManager localActorSystemManager, ActorSystemConfiguration actorSystemConfiguration)
        {
            var path = $"{actorSystemConfiguration.Path}QueryForwarderActor";
            QueryForwarderActor = localActorSystemManager.ActorSystem.ActorSelection(path).ResolveOne(TimeSpan.FromSeconds(30)).Result;
        }
    }
}