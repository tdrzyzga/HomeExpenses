using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Akka.ActorSystem
{
    public interface ILocalActorSystemManager : IDisposable
    {
        global::Akka.Actor.ActorSystem ActorSystem { get; }
    }
}
