using System;
using Akka.Actor;

namespace Core.Akka.ActorSystem
{
    public interface ILocalActorSystemManager : IDisposable
    {
        global::Akka.Actor.ActorSystem ActorSystem { get; }
    }
}