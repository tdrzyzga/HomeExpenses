using Autofac;
using FluentValidation;

namespace HomeExpenses.Message
{
    public class HomeExpensesMessageModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                   .Where(t => t.IsAssignableTo<IValidator>())
                   .AsImplementedInterfaces()
                   .SingleInstance();
        }
    }
}