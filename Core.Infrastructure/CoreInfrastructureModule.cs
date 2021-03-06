﻿using Autofac;
using Core.Infrastructure.Handlers;
using Core.Infrastructure.Repositories;
using MediatR;

namespace Core.Infrastructure
{
    public class CoreInfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(NoTenantRepository<>)).AsImplementedInterfaces();
            builder.RegisterGeneric(typeof(TenantRepository<>)).AsImplementedInterfaces();
            builder.RegisterGeneric(typeof(CommandHandlerInterceptor<>)).AsImplementedInterfaces();
            builder.RegisterGeneric(typeof(QueryHandlerInterceptor<>)).AsImplementedInterfaces();
            builder.RegisterGeneric(typeof(EventHandlerInterceptor<>)).AsImplementedInterfaces();

            builder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();
            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            builder.RegisterAssemblyTypes(ThisAssembly)
                   .AsImplementedInterfaces()
                   .PreserveExistingDefaults();
        }
    }
}