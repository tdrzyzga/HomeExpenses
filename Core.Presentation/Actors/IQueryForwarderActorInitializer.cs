using System.Collections.Generic;
using Akka.Actor;

namespace Core.Presentation.Actors
{
    public interface IQueryForwarderActorInitializer
    {
        void StartQueryForwarderActor(List<IActorRef> autostartedActors);
    }
}