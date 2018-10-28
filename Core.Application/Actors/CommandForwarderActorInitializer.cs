using System.Collections.Generic;
using Akka.Actor;
using Core.Akka.ActorSystem;
using Microsoft.Extensions.Logging;

namespace Core.Application.Actors
{
    public class CommandForwarderActorInitializer : ICommandForwarderActorInitializer
    {
        private readonly ILocalActorSystemManager _localActorSystemManager;
        private readonly ILogger _logger;

        public CommandForwarderActorInitializer(ILocalActorSystemManager localActorSystemManager, ILogger<CommandForwarderActor> logger)
        {
            _localActorSystemManager = localActorSystemManager;
            _logger = logger;
        }

        public void StartCommandForwarderActor(List<IActorRef> autostartedActors)
        {
            var props = Props.Create(() => new CommandForwarderActor(autostartedActors, _logger));
            _localActorSystemManager.ActorSystem.ActorOf(props, "CommandForwarderActor");
        }
    }
}