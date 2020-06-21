using Core.Message.Commands;
using System.Threading.Tasks;
using Core.Message.Events;

namespace Core.Application.MessageBus
{
    public interface IApplicationMessageBus
    {
        Task<ICommandResult> SendCommand<TCommand>(TCommand command) where TCommand : class, ICommand;
        Task SendEvent<TEvent>(TEvent @event) where TEvent : class, IEvent;
    }
}