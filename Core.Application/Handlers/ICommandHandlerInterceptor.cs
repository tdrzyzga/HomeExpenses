using Core.Message.Commands;
using MediatR;

namespace Core.Application.Handlers
{
    public interface ICommandHandlerInterceptor<in TCommand> : IRequestHandler<TCommand, ICommandResult> where TCommand : ICommand
    {
    }
}