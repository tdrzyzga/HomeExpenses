using System;
using System.Collections.Generic;
using System.Reflection;
using Akka.Actor;

namespace Core.Presentation.Actors
{
    public interface IAutostartQueryActorsInitializer
    {
        Dictionary<Type, IActorRef> AutostartedQueryActors { get; }
        void FindAndStartQueryActors(params Assembly[] assembliesToScan);
        void StopAllAutostartedQueryActors();
    }
}