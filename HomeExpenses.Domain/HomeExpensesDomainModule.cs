using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExpenses.Domain
{
    public class HomeExpensesDomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                   .AsImplementedInterfaces()
                   .PreserveExistingDefaults();
        }
    }
}
