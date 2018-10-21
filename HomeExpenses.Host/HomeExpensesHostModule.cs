using Akka.Actor;
using Akka.Configuration;
using Autofac;
using Core.Akka;
using Core.Akka.ActorSystem;
using Core.Application;
using Core.Application.Actors;
using Core.Domain;
using Core.Infrastructure;
using Core.Message.Commands;
using Core.Presentation;
using HomeExpenses.Application;
using HomeExpenses.Domain;
using HomeExpenses.Infrastructure;
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
            builder.RegisterModule<CoreInfrastructureModule>();
            builder.RegisterModule<CoreDomainModule>();
            builder.RegisterModule<CoreApplicationModule>();
            builder.RegisterModule<CorePresentationModule>();
            builder.RegisterModule<CoreAkkaModule>();

            builder.RegisterModule<HomeExpensesInfrastructureModule>();
            builder.RegisterModule<HomeExpensesDomainModule>();
            builder.RegisterModule<HomeExpensesApplicationModule>();
            builder.RegisterModule<HomeExpensesPresentationModule>();

            builder.Register(ctx => new LocalActorSystemManager("HostActorSystem", AkkaConfig)).AsImplementedInterfaces().SingleInstance();
        }
    }
}