namespace Core.Akka.ActorSystem
{
    public class RemoteActorSystemManager : IRemoteActorSystemManager
    {
        public string BasePath { get; }

        public string Name { get; }

        public RemoteActorSystemManager(string name, string tcpHostAndPort = null)
        {
            Name = name;

            BasePath = !string.IsNullOrWhiteSpace(tcpHostAndPort)
                ? $"akka.tcp://{name}@{tcpHostAndPort}".Trim('/', '\\')
                : $"akka://{name}".Trim().Trim('/', '\\');
        }

        public string FullPathForActor(string actorPath)
        {
            actorPath = actorPath.Trim('/', '\\');
            return $"{BasePath}/user/{actorPath}";
        }
    }
}