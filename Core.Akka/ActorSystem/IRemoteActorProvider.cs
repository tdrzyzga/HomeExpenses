using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Akka.ActorSystem
{
    public interface IRemoteActorProvider
    {
        Task<IActorRef> GetOne(string actorName);
    }
}
