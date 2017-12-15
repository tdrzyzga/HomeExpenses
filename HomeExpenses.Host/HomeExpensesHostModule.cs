using Akka.Configuration;
using Autofac;
using Core.Akka;
using Core.Akka.ActorSystem;
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
        private readonly Config AkkaConfig = ConfigurationFactory.ParseString(@"
                                                                        akka {
                                                                            actor {
                                                                                provider = ""Akka.Remote.RemoteActorRefProvider, Akka.Remote""
                                                                            }

                                                                            remote {
                                                                                dot-netty.tcp {
                                                                                    port = 9991
                                                                                    hostname = localhost
                                                                                }
                                                                            }
                                                                        }
                                                                        ");
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
            builder.RegisterModule<HomeExpensesMessageModule>();
            builder.RegisterModule<HomeExpensesInfrastructureModule>();
            builder.RegisterModule<HomeExpensesPresentationModule>();

            builder.Register(ctx => new LocalActorSystemManager("HostActorSystem", AkkaConfig)).AsImplementedInterfaces().SingleInstance();
            builder.Register(ctx => new RemoteActorSystemManager("HostActorSystem")).AsImplementedInterfaces().SingleInstance();
        }
    }
}
