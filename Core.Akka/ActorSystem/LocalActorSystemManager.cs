using Akka.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Akka.ActorSystem
{
    public class LocalActorSystemManager : ILocalActorSystemManager
    {
        public global::Akka.Actor.ActorSystem ActorSystem { get; }

        public LocalActorSystemManager(string name, Config config = null)
        {
            ActorSystem = config == null
                              ? global::Akka.Actor.ActorSystem.Create(name)
                              : global::Akka.Actor.ActorSystem.Create(name, config);
        }

        public void Dispose()
        {
            ActorSystem?.Dispose();
        }
    }
}
