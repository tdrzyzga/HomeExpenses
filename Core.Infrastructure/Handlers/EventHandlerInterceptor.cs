using System;
using System.Linq;
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
            var handlers = _scope.ServiceProvider.GetServices<IEventHandler<TEvent>>().ToArray();

            var tasks = handlers.Select(handler => Task.Run(() => handler.Handle(@event)));

            try
            {
                await Task.WhenAll(tasks);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "Error occured during handling event {Event}", @event);
            }
        }
    }
}