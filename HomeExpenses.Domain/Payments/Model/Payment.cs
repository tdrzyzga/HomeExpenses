using System;
using System.Threading.Tasks;
using Core.Domain.Entities;

namespace HomeExpenses.Domain.Payments.Model
{
    public class Payment : AggregateRoot, IHaveTenant, IDeletable
    {
        
        public Guid? TenantId { get; private set; }
        public bool IsDeleted { get; private set; }
        public Guid? RecipientId { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime DateTime { get; private set; }

        protected Payment()
        {
        }

        public Payment(Guid id, Guid? tenantId, Guid? recipientId, decimal amount, DateTime dateTime) : base(id)
        {
            TenantId = tenantId;
            RecipientId = recipientId;
            Amount = amount;
            DateTime = dateTime;
        }

        public void ChangeRecipient(Guid? recipientId)
        {
            RecipientId = recipientId;
        }

        public void ChangePaymentData(decimal amount, DateTime dateTime)
        {
            Amount = amount;
            DateTime = dateTime;
        }

    }
}