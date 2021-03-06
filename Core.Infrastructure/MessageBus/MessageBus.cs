﻿using Core.Application.MessageBus;
using Core.Message.Commands;
using Core.Message.Queries;
using Core.Presentation.MessageBus;
using MediatR;
using System.Threading.Tasks;
using Core.Message.Events;

namespace Core.Infrastructure.MessageBus
{
    public class MessageBus : IApplicationMessageBus, IPresentationMessageBus
    {
        private readonly IMediator _mediator;

        public MessageBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ICommandResult> SendCommand<TCommand>(TCommand command) where TCommand : class, ICommand
        {
            return await _mediator.Send(command);
        }

        public async Task<IQueryResult> SendQuery<TQuery>(TQuery query) where TQuery : class, IQuery
        {
            return await _mediator.Send(query);
        }
        
        public Task SendEvent<TEvent>(TEvent @event) where TEvent : class, IEvent
        {
            Task.Run(() => _mediator.Publish(@event));
            
            return Task.CompletedTask;
        }
    }
}