using System;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Akka.ActorSystem;
using Core.Message.Commands;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class CommandForwarderActorProvider: ICommandForwarderActorProvider
    {
        private readonly string _commandForwarderActorPath;
        private readonly ILocalActorSystemManager _localActorSystemManager;

        public CommandForwarderActorProvider(ILocalActorSystemManager localActorSystemManager, string commandForwarderActorPath)
        {
            _localActorSystemManager = localActorSystemManager;
            _commandForwarderActorPath = commandForwarderActorPath;
        }

        public async Task<object> Ask<TCommand>(TCommand command) where TCommand: ICommand
        {
            var commandForwarderActor = await _localActorSystemManager.ActorSystem.ActorSelection(_commandForwarderActorPath).ResolveOne(TimeSpan.FromSeconds(30));

            return await commandForwarderActor.Ask(command);
        }
    }
}