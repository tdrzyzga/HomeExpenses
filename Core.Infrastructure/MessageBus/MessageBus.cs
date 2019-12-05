using Core.Application.MessageBus;
using Core.Message.Commands;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
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
            return (await _serviceProvider.GetRequiredService<IBusControl>()
                                          .CreateRequestClient<TCommand>()
                                          .GetResponse<CommandResponse>(command)) as CommandResponse;
        }
    }
}