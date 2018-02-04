using System;
using System.Threading.Tasks;
using Core.Domain.Entities;
using Core.Domain.ValueObjects;

namespace HomeExpenses.Domain.Bill
{
    public class Bill : AggregateRoot
    {
        public string Name { get; private set; }
        public Recipient Recipient { get; private set; }
        public decimal Amount { get; private set; }

        protected Bill()
        {
        }

        public Bill(Guid id, Guid creatorId, string name, Recipient recipient, decimal amount) : base(id, creatorId)
        {
            Name = name;
            Recipient = recipient;
            Amount = amount;
        }

        public Task ChangeName(string name)
        {
            Name = name;

            return Task.CompletedTask;
        }

        public Task ChangeRecipient(string name, AddressValueObject address)
        {
            Recipient.ChangeName(name);
            Recipient.ChangeAddress(address);

            return Task.CompletedTask;
        }

        public Task ChangeAmount(decimal amount)
        {
            Amount = amount;

            return Task.CompletedTask;
        }
    }
}