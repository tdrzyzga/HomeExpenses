using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Akka.Actor;
using Akka.DI.Core;
using Core.Akka.ActorAutostart;
using Core.Akka.ActorSystem;

namespace Core.Application.Actors
{
    public class AutostartCommandActorsInitializer : IAutostartCommandActorsInitializer
    {
        private readonly ILocalActorSystemManager _localActorSystemManager;

        public Dictionary<Type, IActorRef> AutostartedCommandActors { get; }

        public AutostartCommandActorsInitializer(ILocalActorSystemManager localActorSystemManager)
        {
            _localActorSystemManager = localActorSystemManager;
            AutostartedCommandActors = new Dictionary<Type, IActorRef>();
        }

        public void FindAndStartCommandActors(params Assembly[] assembliesToScan)
        {
            if (assembliesToScan == null || assembliesToScan.Length == 0)
            {
                assembliesToScan = Assembly.GetEntryAssembly().GetReferencedAssemblies().Select(Assembly.Load).ToArray();
            }

            var allActorsToStart = assembliesToScan
                                   .SelectMany(assembly => assembly
                                                           .GetTypes().Where(x => x.IsSubclassOf(typeof(ActorBase)) && x.GetInterfaces().Any(y => y.IsGenericType &&
                                                                                                                                                  y.GetGenericTypeDefinition() ==
                                                                                                                                                  typeof(ICommandActor<>))))
                                   .Select(x => new
                                   {
                                       Type = x,
                                       interfaceImplementedType = x.GetInterfaces().Single(y => y.IsGenericType && y.GetGenericTypeDefinition() == typeof(ICommandActor<>)),
                                       Attribute = x.GetCustomAttribute<AutostartActorAttribute>()
                                   })
                                   .Where(x => x.Attribute != null);

            foreach (var actorToStart in allActorsToStart)
            {
                var actor = _localActorSystemManager.ActorSystem.ActorOf(_localActorSystemManager.ActorSystem.DI().Props(actorToStart.Type), actorToStart.Attribute.ActorName);
                AutostartedCommandActors.Add(actorToStart.interfaceImplementedType, actor);
            }
        }

        public void StopAllAutostartedCommandActors()
        {
            foreach (var actor in AutostartedCommandActors)
            {
                var wasStopped = actor.Value.GracefulStop(TimeSpan.FromSeconds(3)).Result;
                if (wasStopped)
                    AutostartedCommandActors.Remove(actor.Key);
            }
        }
    }
}