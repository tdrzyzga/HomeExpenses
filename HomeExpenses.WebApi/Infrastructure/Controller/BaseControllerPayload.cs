using Core.Application.MessageBus;
using System;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class BaseControllerPayload
    {
        public IServiceProvider ServiceProvider { get; }
        public IApplicationMessageBus _messageBus;

        public BaseControllerPayload(IServiceProvider serviceProvider, IApplicationMessageBus messageBus)
        {
            ServiceProvider = serviceProvider;
            _messageBus = messageBus;
        }
    }
}