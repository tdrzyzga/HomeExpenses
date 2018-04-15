using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain.Entity;
using Core.Domain.ValueObjects;

namespace HomeExpenses.Domain.Bills.Model
{
    public class Bill : AggregateRoot, IHaveTenant
    {
        public Guid? TenantId { get; }
        public string Name { get; private set; }
        public Recipient Recipient { get; private set; }
        public ICollection<Payment> Payments { get; private set; }

        protected Bill()
        {
        }

        public Bill(Guid id, Guid? tenantId, string name, Recipient recipient, ICollection<Payment> payments) : base(id)
        {
            TenantId = tenantId;
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