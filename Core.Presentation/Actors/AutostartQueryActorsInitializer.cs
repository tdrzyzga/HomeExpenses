using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Akka.Actor;
using Akka.DI.Core;
using Core.Akka.ActorAutostart;
using Core.Akka.ActorSystem;

namespace Core.Presentation.Actors
{
    public class AutostartQueryActorsInitializer : IAutostartQueryActorsInitializer
    {
        private readonly ILocalActorSystemManager _localActorSystemManager;

        public Dictionary<Type, IActorRef> AutostartedQueryActors { get; }

        public AutostartQueryActorsInitializer(ILocalActorSystemManager localActorSystemManager)
        {
            _localActorSystemManager = localActorSystemManager;
            AutostartedQueryActors = new Dictionary<Type, IActorRef>();
        }

        public void FindAndStartQueryActors(params Assembly[] assembliesToScan)
        {
            if (assembliesToScan == null || assembliesToScan.Length == 0)
            {
                assembliesToScan = Assembly.GetEntryAssembly().GetReferencedAssemblies().Select(Assembly.Load).ToArray();
            }

            var allActorsToStart = assembliesToScan
                                   .SelectMany(assembly => assembly
                                                           .GetTypes().Where(x => x.IsSubclassOf(typeof(ActorBase)) && x.GetInterfaces().Any(y => y.IsGenericType &&
                                                                                                                                                  y.GetGenericTypeDefinition() ==
                                                                                                                                                  typeof(IQueryActor<>))))
                                   .Select(x => new
                                   {
                                       Type = x, interfaceImplementedType = x.GetInterfaces().Single(y => y.IsGenericType && y.GetGenericTypeDefinition() == typeof(IQueryActor<>)),
                                       Attribute = x.GetCustomAttribute<AutostartActorAttribute>()
                                   })
                                   .Where(x => x.Attribute != null);

            foreach (var actorToStart in allActorsToStart)
            {
                var actor = _localActorSystemManager.ActorSystem.ActorOf(_localActorSystemManager.ActorSystem.DI().Props(actorToStart.Type), actorToStart.Attribute.ActorName);
                AutostartedQueryActors.Add(actorToStart.interfaceImplementedType, actor);
            }
        }

        public void StopAllAutostartedQueryActors()
        {
            foreach (var actor in AutostartedQueryActors)
            {
                var wasStopped = actor.Value.GracefulStop(TimeSpan.FromSeconds(3)).Result;
                if (wasStopped)
                    AutostartedQueryActors.Remove(actor.Key);
            }
        }
    }
}