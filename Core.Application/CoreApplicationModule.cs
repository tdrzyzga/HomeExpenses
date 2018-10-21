using Akka.Actor;
using Autofac;
using Core.Application.Actors;

namespace Core.Application
{
    public class CoreApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                   .AsImplementedInterfaces()
                   .PreserveExistingDefaults();
        }
    }
}