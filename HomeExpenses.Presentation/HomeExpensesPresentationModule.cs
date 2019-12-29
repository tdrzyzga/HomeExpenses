using Autofac;
using Core.Presentation.Pagination;

namespace HomeExpenses.Presentation
{
    public class HomeExpensesPresentationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                   .Where(t => t.IsClosedTypeOf(typeof(ISortExpression<>)))
                   .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(ThisAssembly)
                   .AsImplementedInterfaces()
                   .PreserveExistingDefaults();
        }
    }
}