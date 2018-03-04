using Akka.Configuration;
using Autofac;
using Core.Akka;
using Core.Akka.ActorSystem;

namespace HomeExpenses.WebApi
{
    public class HomeExpensesWebApiModule : Module
    {
        private readonly Config AkkaConfig = ConfigurationFactory.ParseString(@"
                                                                        akka {
                                                                            actor {
                                                                                provider = ""Akka.Remote.RemoteActorRefProvider, Akka.Remote""
                                                                            }

                                                                            remote {
                                                                                dot-netty.tcp {
                                                                                    port = 9992
                                                                                    hostname = localhost
                                                                                }
                                                                            }
                                                                        }
                                                                        ");

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<CoreAkkaModule>();
            builder.Register(ctx => new LocalActorSystemManager("WebApiActorSystem", AkkaConfig)).AsImplementedInterfaces().SingleInstance();
        }
    }
}