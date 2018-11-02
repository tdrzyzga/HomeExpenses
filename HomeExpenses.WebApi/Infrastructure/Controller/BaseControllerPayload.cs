using System;
using Core.Akka.ActorSystem;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class BaseControllerPayload
    {
        public IServiceProvider ServiceProvider { get; }
        public CommandForwarderActorProvider CommandForwarderActorProvider { get; }
        public QueryForwarderActorProvider QueryForwarderActorProvider { get; }
        public ILocalActorSystemManager LocalActorSystemManager { get; }

        public BaseControllerPayload(IServiceProvider serviceProvider,
                                     CommandForwarderActorProvider commandForwarderActorProvider,
                                     QueryForwarderActorProvider queryForwarderActorProvider,
                                     ILocalActorSystemManager localActorSystemManager)
        {
            ServiceProvider = serviceProvider;
            CommandForwarderActorProvider = commandForwarderActorProvider;
            QueryForwarderActorProvider = queryForwarderActorProvider;
            LocalActorSystemManager = localActorSystemManager;
        }
    }
}