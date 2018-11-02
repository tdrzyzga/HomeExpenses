using System;
using System.Collections.Generic;
using System.Reflection;
using Akka.Actor;

namespace Core.Application.Actors
{
    public interface IAutostartCommandActorsInitializer
    {
        Dictionary<Type, IActorRef> AutostartedCommandActors { get; }
        void FindAndStartCommandActors(params Assembly[] assembliesToScan);
        void StopAllAutostartedCommandActors();
    }
}