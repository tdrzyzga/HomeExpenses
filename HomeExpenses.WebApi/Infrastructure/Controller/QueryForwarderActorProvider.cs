using System;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Akka.ActorSystem;
using Core.Message.Queries;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class QueryForwarderActorProvider: IQueryForwarderActorProvider
    {
        private readonly ILocalActorSystemManager _localActorSystemManager;
        private readonly string _queryForwarderActorPath;

        public QueryForwarderActorProvider(ILocalActorSystemManager localActorSystemManager, string queryForwarderActorPath)
        {
            _localActorSystemManager = localActorSystemManager;
            _queryForwarderActorPath = queryForwarderActorPath;
        }
        
        public async Task<object> Ask<TQuery>(TQuery query) where TQuery: IQuery
        {
            var queryForwarderActor = await _localActorSystemManager.ActorSystem.ActorSelection(_queryForwarderActorPath).ResolveOne(TimeSpan.FromSeconds(30));

            return await queryForwarderActor.Ask(query);
        }
    }
}