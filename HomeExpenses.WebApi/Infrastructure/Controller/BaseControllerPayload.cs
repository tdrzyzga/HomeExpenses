using System;
using Core.Akka.ActorSystem;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class BaseControllerPayload
    {
        public ActorSystemConfiguration ActorSystemConfiguration { get; }
        public ILocalActorSystemManager LocalActorSystemManager { get; }
        public IServiceProvider ServiceProvider { get; }

        public BaseControllerPayload(ActorSystemConfiguration actorSystemConfiguration, ILocalActorSystemManager localActorSystemManager, IServiceProvider serviceProvider)
        {
            ActorSystemConfiguration = actorSystemConfiguration;
            LocalActorSystemManager = localActorSystemManager;
            ServiceProvider = serviceProvider;
        }
    }
}