using System;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Akka.ActorSystem;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class CommandForwarderActorProvider
    {
        private readonly string _commandForwarderActorPath;
        private readonly ILocalActorSystemManager _localActorSystemManager;

        public IActorRef DeadLetters => _localActorSystemManager.ActorSystem.DeadLetters;
        public IActorRef CommandForwarderActor { get; private set; }

        public CommandForwarderActorProvider(ILocalActorSystemManager localActorSystemManager, string commandForwarderActorPath)
        {
            _localActorSystemManager = localActorSystemManager;
            _commandForwarderActorPath = commandForwarderActorPath;

            Task.Run(SetCommandForwarderActor).Wait();
        }

        private async Task SetCommandForwarderActor()
        {
            CommandForwarderActor = await _localActorSystemManager.ActorSystem.ActorSelection(_commandForwarderActorPath).ResolveOne(TimeSpan.FromSeconds(30));
        }
    }
}