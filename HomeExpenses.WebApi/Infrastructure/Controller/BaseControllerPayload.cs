using Core.Application.MessageBus;
using Core.Presentation.MessageBus;
using System;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class BaseControllerPayload
    {
        public IServiceProvider ServiceProvider { get; }
        public IApplicationMessageBus ApplicationMessageBus { get; }
        public IPresentationMessageBus PresentationMessageBus { get; }

        public BaseControllerPayload(IServiceProvider serviceProvider,
                                     IApplicationMessageBus applicationMessageBus,
                                     IPresentationMessageBus presentationMessageBus)
        {
            ServiceProvider = serviceProvider;
            ApplicationMessageBus = applicationMessageBus;
            PresentationMessageBus = presentationMessageBus;
        }
    }
}