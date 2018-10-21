using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.DI.Core;
using Core.Akka.ActorAutostart;
using Core.Akka.ActorSystem;
using Core.Message.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Application.Actors
{
    public class CommandForwarderActorInitializer: ICommandForwarderActorInitializer
    {
        private readonly ILocalActorSystemManager _localActorSystemManager;

        public CommandForwarderActorInitializer(ILocalActorSystemManager localActorSystemManager)
        {
            _localActorSystemManager = localActorSystemManager;
        }

        public void StartCommandForwarderActor(IServiceProvider serviceProvider, List<IActorRef> autostartedActors)
        {
            var props = Props.Create(() => new CommandForwarderActor(autostartedActors));
            _localActorSystemManager.ActorSystem.ActorOf(props, "CommandForwarderActor");
        }
    }

    public interface ICommandForwarderActorInitializer
    {
        void StartCommandForwarderActor(IServiceProvider serviceProvider, List<IActorRef> autostartedActors);
    }
}