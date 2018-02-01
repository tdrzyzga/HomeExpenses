using Autofac;
using Core.Akka;
using Core.Application;
using Core.Domain;
using Core.Infrastructure;
using Core.Message;
using Core.Presentation;
using HomeExpenses.Application;
using HomeExpenses.Domain;
using HomeExpenses.Infrastructure;
using HomeExpenses.Message;
using HomeExpenses.Presentation;

namespace HomeExpenses.Host
{
    public class HomeExpensesHostModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {            
            builder.RegisterModule<CoreAkkaModule>();
            builder.RegisterModule<CoreApplicationModule>();
            builder.RegisterModule<CoreDomainModule>();
            builder.RegisterModule<CoreMessageModule>();
            builder.RegisterModule<CoreInfrastructureModule>();
            builder.RegisterModule<CorePresentationModule>();

            builder.RegisterModule<HomeExpensesApplicationModule>();
            builder.RegisterModule<HomeExpensesDomainModule>();
            builder.RegisterModule<HomeExpensesInfrastructureModule>();
            builder.RegisterModule<HomeExpensesPresentationModule>();
        }
    }
}
