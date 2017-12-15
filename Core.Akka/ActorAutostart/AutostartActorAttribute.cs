using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Akka.ActorAutostart
{
    public class AutostartActorAttribute : Attribute
    {
        public string ActorName { get; }

        public AutostartActorAttribute(string actorName)
        {
            ActorName = actorName;
        }
    }
}
