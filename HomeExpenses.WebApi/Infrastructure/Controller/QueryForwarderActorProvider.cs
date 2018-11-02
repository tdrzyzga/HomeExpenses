using System;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Akka.ActorSystem;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class QueryForwarderActorProvider
    {
        private readonly ILocalActorSystemManager _localActorSystemManager;
        private readonly string _queryForwarderActorPath;

        public IActorRef QueryForwarderActor { get; private set; }

        public QueryForwarderActorProvider(ILocalActorSystemManager localActorSystemManager, string queryForwarderActorPath)
        {
            _localActorSystemManager = localActorSystemManager;
            _queryForwarderActorPath = queryForwarderActorPath;

            Task.Run(SetQueryForwarderActor).Wait();
        }

        public async Task SetQueryForwarderActor()
        {
            QueryForwarderActor = await _localActorSystemManager.ActorSystem.ActorSelection(_queryForwarderActorPath).ResolveOne(TimeSpan.FromSeconds(30));
        }
    }
}