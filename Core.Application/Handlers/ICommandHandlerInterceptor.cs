using Core.Message.Commands;
using System.Threading.Tasks;

namespace Core.Application.Handlers
{
    public interface ICommandHandlerInterceptor<TCommand> where TCommand : ICommand
    {
        Task<CommandResponse> Handle(TCommand command);
    }
}