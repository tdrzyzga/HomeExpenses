using Core.Application.MessageBus;
using Core.Message.Commands;
using MediatR;
using System.Threading.Tasks;

namespace Core.Infrastructure.MessageBus
{
    public class MessageBus : IApplicationMessageBus
    {
        private readonly IMediator _mediator;

        public MessageBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ICommandResult> SendCommand<TCommand>(TCommand command) where TCommand : ICommand
        {
            return await _mediator.Send(command);
        }
    }
}