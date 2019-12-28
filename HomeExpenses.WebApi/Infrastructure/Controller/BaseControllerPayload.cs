using Core.Application.MessageBus;
using System;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class BaseControllerPayload
    {
        public IServiceProvider ServiceProvider { get; }
        public IApplicationMessageBus ApplicationMessageBus;

        public BaseControllerPayload(IServiceProvider serviceProvider, IApplicationMessageBus applicationMessageBus)
        {
            ServiceProvider = serviceProvider;
            ApplicationMessageBus = applicationMessageBus;
        }
    }
}