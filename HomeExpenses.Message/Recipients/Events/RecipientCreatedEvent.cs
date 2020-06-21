using System;
using Core.Message.Events;

namespace HomeExpenses.Message.Recipients.Events
{
    public class RecipientCreatedEvent : BaseEvent
    {
        public Guid RecipientId { get; }
        public string Name { get; }

        public RecipientCreatedEvent(Guid recipientId, string name)
        {
            RecipientId = recipientId;
            Name = name;
        }
    }
}