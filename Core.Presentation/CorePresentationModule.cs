using Autofac;
using Core.Presentation.Pagination;

namespace Core.Presentation
{
    public class CorePresentationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(DefaultSortExpression<>)).AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(ThisAssembly)
                   .AsImplementedInterfaces()
                   .PreserveExistingDefaults();
        }
    }
}