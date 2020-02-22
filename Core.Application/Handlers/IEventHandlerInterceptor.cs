using Core.Message.Events;
using MediatR;

namespace Core.Application.Handlers
{
    public interface IEventHandlerInterceptor<in TEvent> : INotificationHandler<TEvent>
        where TEvent : class, IEvent
    {
    }
}