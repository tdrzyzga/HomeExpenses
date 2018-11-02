using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Message.Commands;
using Microsoft.Extensions.Logging;

namespace Core.Application.Actors
{
    public class CommandForwarderActor : ReceiveActor
    {
        private readonly Dictionary<Type, IActorRef> _autostartedCommandActors;
        private readonly ILogger _logger;

        public CommandForwarderActor(Dictionary<Type, IActorRef> autostartedCommandActors, ILogger logger)
        {
            _autostartedCommandActors = autostartedCommandActors;
            _logger = logger;

            ReceiveAsync<ICommand>(Handle);
        }

        private Task Handle<TCommand>(TCommand command) where TCommand : ICommand
        {
            try
            {
                var actor = GetActor(command);

                _logger.LogDebug("Command {Command} forwarding by CommandForwarderActor", command);

                actor.Forward(command);
            }
            catch (Exception exception)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(exception, "Error occured during forwarding command {Command}", command);

                Sender.Tell(new CommandErrorResponse(errorId, "GENERAL ERROR"));
            }

            return Task.CompletedTask;
        }

        private IActorRef GetActor<TCommand>(TCommand command) where TCommand : ICommand
        {
            var commandType = command.GetType();

            var actorInterfaceImplementedType = typeof(ICommandActor<>).MakeGenericType(commandType);

            var actor = _autostartedCommandActors.GetValueOrDefault(actorInterfaceImplementedType);

            if (actor == null)
            {
                throw new ActorNotFoundException();
            }

            return actor;
        }
    }
}