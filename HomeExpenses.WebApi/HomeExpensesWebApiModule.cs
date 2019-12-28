using Autofac;
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

namespace HomeExpenses.WebApi
{
    public class HomeExpensesWebApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<CoreApplicationModule>();
            builder.RegisterModule<CoreDomainModule>();
            builder.RegisterModule<CoreInfrastructureModule>();
            builder.RegisterModule<CoreMessageModule>();
            builder.RegisterModule<CorePresentationModule>();

            builder.RegisterModule<HomeExpensesApplicationModule>();
            builder.RegisterModule<HomeExpensesDomainModule>();
            builder.RegisterModule<HomeExpensesInfrastructureModule>();
            builder.RegisterModule<HomeExpensesMessageModule>();
            builder.RegisterModule<HomeExpensesPresentationModule>();
        }
    }
}