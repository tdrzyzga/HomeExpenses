using System;
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
        private readonly IServiceProvider _serviceProvider;

        public CommandForwarderActorInitializer(ILocalActorSystemManager localActorSystemManager, ILogger<CommandForwarderActor> logger, IServiceProvider serviceProvider)
        {
            _localActorSystemManager = localActorSystemManager;
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        public void StartCommandForwarderActor(List<IActorRef> autostartedActors)
        {
            var props = Props.Create(() => new CommandForwarderActor(autostartedActors, _logger, _serviceProvider));
            _localActorSystemManager.ActorSystem.ActorOf(props, "CommandForwarderActor");
        }
    }
}