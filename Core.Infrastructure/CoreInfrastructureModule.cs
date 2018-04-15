using Autofac;
using Core.Infrastructure.Repository;

namespace Core.Infrastructure
{
    public class CoreInfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(TenantRepository<>)).AsImplementedInterfaces().InstancePerDependency();
            builder.RegisterGeneric(typeof(NoTenantRepository<>)).AsImplementedInterfaces().InstancePerDependency();

            builder.RegisterAssemblyTypes(ThisAssembly)
                   .AsImplementedInterfaces()
                   .PreserveExistingDefaults();
        }
    }
}