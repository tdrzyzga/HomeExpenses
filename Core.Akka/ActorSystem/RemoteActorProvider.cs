using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace Core.Akka.ActorSystem
{
    public class RemoteActorProvider : IRemoteActorProvider
    {
        private readonly ILocalActorSystemManager _localActorSystemManager;
        private readonly IRemoteActorSystemManager _remoteActorSystemManager;

        public RemoteActorProvider(ILocalActorSystemManager localActorSystemManager, IRemoteActorSystemManager remoteActorSystemManager)
        {
            _localActorSystemManager = localActorSystemManager;
            _remoteActorSystemManager = remoteActorSystemManager;
        }

        public async Task<IActorRef> GetOne(string actorName)
        {
            var path = _remoteActorSystemManager.FullPathForActor(actorName);
            return await _localActorSystemManager.ActorSystem.ActorSelection(path).ResolveOne(TimeSpan.FromSeconds(30));
        }
    }
}
