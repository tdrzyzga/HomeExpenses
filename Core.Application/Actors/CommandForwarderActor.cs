using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Akka;
using Akka.Actor;
using Akka.DI.Core;
using Akka.Util;
using Core.Akka.ActorAutostart;
using Core.Akka.ActorSystem;

namespace Core.Application.Actors
{
    public class CommandForwarderActor : ReceiveActor
    {
        private readonly List<IActorRef> _autostartedActors;
        
        public CommandForwarderActor(List<IActorRef> autostartedActors)
        {
            _autostartedActors = autostartedActors;
            ReceiveAny(Handle);
        }

        private void Handle(object command)
        {
            var commandType = command.GetType();

            var genericType = typeof(ICommandActor<>).MakeGenericType(commandType);

            var actorInfo = Assembly.GetEntryAssembly().GetReferencedAssemblies().Select(Assembly.Load)
                                    .SelectMany(x => x.GetExportedTypes().Where(y => y.Implements(genericType)))
                                    .Select(x => new {Name = x.Name})
                                    .SingleOrDefault();

            if (actorInfo == null)
            {
                return;
            }

            var actor = _autostartedActors.Find(x => x.Path.Name == actorInfo.Name);

            actor.Forward(command);
        }
    }
}