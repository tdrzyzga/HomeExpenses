using System.Threading.Tasks;
using Core.Message.Events;

namespace Core.Application.Handlers
{
    public interface IEventHandler
    {
        
    }
    
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent: class, IEvent
    {
        Task Handle(TEvent @event);
    }
}