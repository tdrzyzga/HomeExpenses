using System.Threading.Tasks;
using Akka.Actor;

namespace Core.Akka.ActorSystem
{
    public interface IRemoteActorProvider
    {
        Task<IActorRef> GetOne(string actorName);
    }
}