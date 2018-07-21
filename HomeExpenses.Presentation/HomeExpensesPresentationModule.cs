using Akka.Actor;
using Autofac;

namespace HomeExpenses.Presentation
{
    public class HomeExpensesPresentationModule : Module
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