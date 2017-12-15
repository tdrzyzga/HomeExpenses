using Akka.Configuration;
using Autofac;
using Core.Akka;
using Core.Akka.ActorSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeExpenses.WebApi
{
    public class HomeExpensesWebApiModule : Module
    {
        private readonly Config AkkaConfigLocal = ConfigurationFactory.ParseString(@"
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

        private readonly Config AkkaConfigRemote = ConfigurationFactory.ParseString(@"
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
            builder.Register(ctx => new LocalActorSystemManager("WebApiActorSystem", AkkaConfigLocal)).AsImplementedInterfaces().SingleInstance();
            //builder.Register(ctx => new RemoteActorSystemManager("HostActorSystem", "localhost:9991")).AsImplementedInterfaces().SingleInstance();
        }
    }
}
