using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Akka.Actor;
using Akka.DI.Core;
using Core.Akka.ActorSystem;

namespace Core.Akka.ActorAutostart
{
    public class AutostartActorInitializer : IAutostartActorInitializer
    {
        private readonly List<IActorRef> _autostartedActors;
        private readonly ILocalActorSystemManager _localActorSystemManager;

        public List<IActorRef> AutostartedActors => _autostartedActors.ToList();

        public AutostartActorInitializer(ILocalActorSystemManager localActorSystemManager)
        {
            _localActorSystemManager = localActorSystemManager;
            _autostartedActors = new List<IActorRef>();
        }

        public void FindAndStartActors(params Assembly[] assembliesToScan)
        {
            if (assembliesToScan == null || assembliesToScan.Length == 0)
            {
                assembliesToScan = Assembly.GetEntryAssembly().GetReferencedAssemblies().Select(Assembly.Load).ToArray();
            }

            var allActorsToStart = assembliesToScan.SelectMany(assembly => assembly.GetTypes().Where(x => x.IsSubclassOf(typeof(ActorBase))))
                                                   .Select(x => new {Type = x, Attribute = x.GetCustomAttribute<AutostartActorAttribute>()})
                                                   .Where(x => x.Attribute != null);

            foreach (var actorToStart in allActorsToStart)
            {
                var actor = _localActorSystemManager.ActorSystem.ActorOf(_localActorSystemManager.ActorSystem.DI().Props(actorToStart.Type), actorToStart.Attribute.ActorName);
                _autostartedActors.Add(actor);
            }
        }

        public void StopAllAutostartedActors()
        {
            foreach (var actor in _autostartedActors.ToList())
            {
                var wasStopped = actor.GracefulStop(TimeSpan.FromSeconds(3)).Result;
                if (wasStopped)
                    _autostartedActors.Remove(actor);
            }
        }
    }
}