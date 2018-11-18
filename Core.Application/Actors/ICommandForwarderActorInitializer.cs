using System;
using System.Collections.Generic;
using Akka.Actor;

namespace Core.Application.Actors
{
    public interface ICommandForwarderActorInitializer
    {
        void StartCommandForwarderActor(Dictionary<Type, IActorRef> autostartedActors);
    }
}