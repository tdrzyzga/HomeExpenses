using Core.Akka.ActorSystem;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class BaseControllerPayload
    {
        public ActorSystemConfiguration ActorSystemConfiguration { get; }
        public ILocalActorSystemManager LocalActorSystemManager { get; }

        public BaseControllerPayload(ActorSystemConfiguration actorSystemConfiguration, ILocalActorSystemManager localActorSystemManager)
        {
            ActorSystemConfiguration = actorSystemConfiguration;
            LocalActorSystemManager = localActorSystemManager;
        }
    }
}