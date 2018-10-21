using System;
using Akka.Actor;
using Core.Akka.ActorSystem;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class CommandForwarderActorProvider
    {
        public IActorRef CommandForwarderActor { get; }

        public CommandForwarderActorProvider(ILocalActorSystemManager localActorSystemManager, ActorSystemConfiguration actorSystemConfiguration)
        {
            var path = $"{actorSystemConfiguration.Path}CommandForwarderActor";
            CommandForwarderActor = localActorSystemManager.ActorSystem.ActorSelection(path).ResolveOne(TimeSpan.FromSeconds(30)).Result;
        }
    }
}