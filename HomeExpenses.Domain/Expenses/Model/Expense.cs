using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain.Entity;
using Core.Domain.ValueObjects;
using HomeExpenses.Domain.Bills.Exceptions;

namespace HomeExpenses.Domain.Bills.Model
{
    public class Expense : AggregateRoot, IHaveTenant
    {
        public Guid? TenantId { get; private set; }
        public BillType Type { get; private set; }
        public string Name { get; private set; }
        public DateTime? DateOfPayment { get; private set; }
        public int? MonthInterval { get; private set; }
        public Recipient Recipient { get; private set; }
        public ICollection<Payment> Payments { get; private set; }

        protected Expense()
        {
        }

        public Expense(Guid id, Guid? tenantId, string name, BillType type, DateTime? dateOfPayment, int? monthInterval, Recipient recipient, ICollection<Payment> payments)
            : base(id)
        {
            TenantId = tenantId;
            Name = name;
            Type = type;
            DateOfPayment = dateOfPayment;
            MonthInterval = monthInterval;
            Recipient = recipient;
            Payments = payments;
        }

        public Task ChangeName(string name)
        {
            Name = name;

            return Task.CompletedTask;
        }

        public Task ChangePaymentPeriod(DateTime dateOfTime, int monthInterval)
        {
            if (Type == BillType.Disposable)
            {
                throw new InvalidOperationInThisBillTypeException();
            }

            DateOfPayment = dateOfTime;
            MonthInterval = monthInterval;

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