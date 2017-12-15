using Akka.Actor;
using Autofac;
using System;

namespace HomeExpenses.Application
{
    public class HomeExpensesApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                    .Where(t => t.IsAssignableTo<ReceiveActor>())
                    .AsSelf();

            builder.RegisterAssemblyTypes(ThisAssembly)
                   .AsImplementedInterfaces()
                   .PreserveExistingDefaults();
        }
    }
}
