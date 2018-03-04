using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain.Entities;
using Core.Domain.ValueObjects;

namespace HomeExpenses.Domain.Bill.Model
{
    public class Bill : AggregateRoot
    {
        public string Name { get; private set; }
        public Recipient Recipient { get; private set; }
        public ICollection<Payment> Payments { get; private set; }

        protected Bill()
        {
        }

        public Bill(Guid id, Guid creatorId, string name, Recipient recipient, ICollection<Payment> payments) : base(id, creatorId)
        {
            Name = name;
            Recipient = recipient;
            Payments = payments;
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

        public Task AddPayment(decimal amount, DateTime dateTime)
        {
            Payments.Add(new Payment(Guid.NewGuid(), amount, dateTime));

            return Task.CompletedTask;
        }
    }
}