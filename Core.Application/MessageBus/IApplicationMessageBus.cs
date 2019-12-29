using Core.Message.Commands;
using System.Threading.Tasks;

namespace Core.Application.MessageBus
{
    public interface IApplicationMessageBus
    {
        Task<ICommandResult> SendCommand<TCommand>(TCommand command) where TCommand : class, ICommand;
    }
}