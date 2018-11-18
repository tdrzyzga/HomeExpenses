using System;
using Core.Akka.ActorSystem;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class BaseControllerPayload
    {
        public IServiceProvider ServiceProvider { get; }
        public ICommandForwarderActorProvider CommandForwarderActorProvider { get; }
        public IQueryForwarderActorProvider QueryForwarderActorProvider { get; }
        public ILocalActorSystemManager LocalActorSystemManager { get; }

        public BaseControllerPayload(IServiceProvider serviceProvider,
                                     ICommandForwarderActorProvider commandForwarderActorProvider,
                                     IQueryForwarderActorProvider queryForwarderActorProvider,
                                     ILocalActorSystemManager localActorSystemManager)
        {
            ServiceProvider = serviceProvider;
            CommandForwarderActorProvider = commandForwarderActorProvider;
            QueryForwarderActorProvider = queryForwarderActorProvider;
            LocalActorSystemManager = localActorSystemManager;
        }
    }
}