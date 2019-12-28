using Core.Application.MessageBus;
using Core.Message.Commands;
using System;
using System.Threading.Tasks;

namespace Core.Infrastructure.MessageBus
{
    public class MessageBus : IApplicationMessageBus
    {
        private readonly IServiceProvider _serviceProvider;

        public MessageBus(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task<CommandResponse> SendCommand<TCommand>(TCommand command) where TCommand : class, ICommand
        {
            throw new NotImplementedException();
        }
    }
}