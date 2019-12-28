using Core.Message.Commands;
using System.Threading.Tasks;

namespace Core.Application.MessageBus
{
    public interface IApplicationMessageBus
    {
        Task<ICommandResponse> SendCommand<TCommand>(TCommand command) where TCommand : ICommand;
    }
}