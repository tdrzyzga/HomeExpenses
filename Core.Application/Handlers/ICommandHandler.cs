using Core.Message.Commands;
using System.Threading.Tasks;

namespace Core.Application.Handlers
{
    public interface ICommandHandler
    {
    }

    public interface ICommandHandler<in TCommand> : ICommandHandler
        where TCommand : ICommand
    {
        Task Handle(TCommand command);
    }
}