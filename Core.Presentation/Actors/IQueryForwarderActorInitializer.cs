using System;
using System.Collections.Generic;
using Akka.Actor;

namespace Core.Presentation.Actors
{
    public interface IQueryForwarderActorInitializer
    {
        void StartQueryForwarderActor(Dictionary<Type, IActorRef> autostartedActors);
    }
}