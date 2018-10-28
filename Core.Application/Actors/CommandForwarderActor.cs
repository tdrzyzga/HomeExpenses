using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Util;
using Core.Message.Commands;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Core.Application.Actors
{
    public class CommandForwarderActor : ReceiveActor
    {
        private readonly List<IActorRef> _autostartedActors;
        private readonly ILogger _logger;

        public CommandForwarderActor(List<IActorRef> autostartedActors, ILogger logger)
        {
            _autostartedActors = autostartedActors;
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

            var interfaceType = typeof(ICommandActor<>).MakeGenericType(commandType);

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