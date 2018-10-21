using System;
using System.Collections.Generic;
using Akka.Actor;

namespace Core.Application.Actors
{
    public interface ICommandForwarderActorInitializer
    {
        void StartCommandForwarderActor(List<IActorRef> autostartedActors);
    }
}