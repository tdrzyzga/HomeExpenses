using System;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class BaseControllerPayload
    {
        public IServiceProvider ServiceProvider { get; }
        public CommandForwarderActorProvider CommandForwarderActorProvider { get; }

        public BaseControllerPayload(IServiceProvider serviceProvider,
                                     CommandForwarderActorProvider commandForwarderActorProvider)
        {
            ServiceProvider = serviceProvider;
            CommandForwarderActorProvider = commandForwarderActorProvider;
        }
    }
}