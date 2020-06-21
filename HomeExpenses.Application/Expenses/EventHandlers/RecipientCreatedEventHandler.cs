using System;
using System.Threading.Tasks;
using Core.Application.Handlers;
using HomeExpenses.Message.Recipients.Events;
using Microsoft.Extensions.Logging;

namespace HomeExpenses.Application.Expenses.EventHandlers
{
    public class RecipientCreatedEventHandler : IEventHandler<RecipientCreatedEvent>
    {
        private readonly ILogger<RecipientCreatedEventHandler> _logger;

        public RecipientCreatedEventHandler(ILogger<RecipientCreatedEventHandler> logger)
        {
            _logger = logger;
        }

        public async Task Handle(RecipientCreatedEvent @event)
        {
            _logger.LogDebug("Recipient {recipientId} {recipientName} created {dateTime} -- expenses", @event.RecipientId, @event.Name,
                             DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));
            throw new ArgumentNullException();
        }
    }
}