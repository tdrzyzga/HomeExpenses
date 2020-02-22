using System;
using System.Threading;
using System.Threading.Tasks;
using Core.Application.Handlers;
using Core.Message.Events;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Core.Infrastructure.Handlers
{
    public class EventHandlerInterceptor<TEvent> : IEventHandlerInterceptor<TEvent> where TEvent: class, IEvent
    {
        private readonly ILogger<EventHandlerInterceptor<TEvent>> _logger;
        private readonly IServiceScope _scope;

        public EventHandlerInterceptor(IServiceProvider serviceProvider, ILogger<EventHandlerInterceptor<TEvent>> logger)
        {
            _scope = serviceProvider.CreateScope();
            _logger = logger;
        }

        public async Task Handle(TEvent @event, CancellationToken cancellationToken)
        {
            var handler = _scope.ServiceProvider.GetRequiredService<IEventHandler<TEvent>>();

            await handler.Handle(@event);
        }
    }
}