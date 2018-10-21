using System;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class BaseControllerPayload
    {
        public IServiceProvider ServiceProvider { get; }
        public CommandForwarderActorProvider CommandForwarderActorProvider { get; }
        public QueryForwarderActorProvider QueryForwarderActorProvider { get; }

        public BaseControllerPayload(IServiceProvider serviceProvider,
                                     CommandForwarderActorProvider commandForwarderActorProvider,
                                     QueryForwarderActorProvider queryForwarderActorProvider)
        {
            ServiceProvider = serviceProvider;
            CommandForwarderActorProvider = commandForwarderActorProvider;
            QueryForwarderActorProvider = queryForwarderActorProvider;
        }
    }
}