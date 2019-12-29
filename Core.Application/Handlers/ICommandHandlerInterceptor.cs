using Core.Message.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Application.Handlers
{
    public interface ICommandHandlerInterceptor<TCommand> : IRequestHandler<TCommand, ICommandResult> where TCommand : ICommand
    {
    }
}