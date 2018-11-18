using Core.Message.Commands;

namespace Core.Application.Actors
{
    public interface ICommandActor<TCommand> where TCommand : ICommand
    {
    }
}