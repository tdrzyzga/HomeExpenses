using Autofac;
using Core.Application.Handlers;
using Core.Infrastructure.Handlers;
using System;
using System.Linq;

namespace HomeExpenses.Application
{
    public class HomeExpensesApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(p => !p.IsDynamic).ToArray();

            var commandHandlerTypes = assemblies.SelectMany(assembly => assembly.GetTypes())
                             .Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommandHandler<>)))
                             .ToArray();

            builder.RegisterTypes(commandHandlerTypes).AsImplementedInterfaces().PreserveExistingDefaults();
            builder.RegisterGeneric(typeof(CommandHandlerInterceptor<>)).AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(ThisAssembly)
                   .AsImplementedInterfaces()
                   .PreserveExistingDefaults();
        }
    }
}