using Autofac;
using Core.Akka;
using Core.Akka.ActorSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeExpenses.WebApi
{
    public class HomeExpensesWebApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<CoreAkkaModule>();
            builder.Register(ctx => new LocalActorSystemManager("MainActorSystem")).AsImplementedInterfaces().SingleInstance();
        }
    }
}
