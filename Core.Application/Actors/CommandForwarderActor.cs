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
        private readonly IServiceProvider _serviceProvider;

        public CommandForwarderActor(List<IActorRef> autostartedActors, ILogger logger, IServiceProvider serviceProvider)
        {
            _autostartedActors = autostartedActors;
            _logger = logger;
            _serviceProvider = serviceProvider;

            ReceiveAsync<ICommand>(Handle);
        }

        private async Task Handle<TCommand>(TCommand command) where TCommand : ICommand
        {
            try
            {
                await Validate(command);
                
                var actor = GetActor(command);
                
                _logger.LogDebug("Command {Command} forwarding by CommandForwarderActor", command);

                actor.Forward(command);
            }
            catch (ValidationException validationException)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(validationException, "Validation errors during forwarding command {Command}", command);

                Sender.Tell(new ValidationErrorResponse(errorId,
                                                        validationException.Errors.Select(x => new CommandErrorResponse.ErrorItem(x.PropertyName, x.ErrorMessage)).ToArray()));
            }
            catch (Exception exception)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(exception, "Error occured during forwarding command {Command}", command);

                Sender.Tell(new CommandErrorResponse(errorId, "GENERAL ERROR"));
            }
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
        
        private async Task Validate<TCommand>(TCommand command) where TCommand : ICommand
        {
            var validator = _serviceProvider.GetService<IValidator<TCommand>>();
            if (validator != null)
            {
                await validator.ValidateAndThrowAsync(command);
            }
        }
    }
}