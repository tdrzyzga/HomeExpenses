using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Akka.ActorSystem
{
    public interface IRemoteActorSystemManager
    {
        string Name { get; }
        string BasePath { get; }
        string FullPathForActor(string actorPath);
    }
}
