using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Core.Akka.ActorAutostart
{
    public interface IAutostartActorInitializer
    {
        List<IActorRef> AutostartedActors { get; }
        void FindAndStartActors(params Assembly[] assembliesToScan);
        void StopAllAutostartedActors();
    }
}
