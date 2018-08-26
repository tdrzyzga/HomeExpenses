using System;
using System.Threading.Tasks;
using Core.Domain.Entities;

namespace HomeExpenses.Domain.Expenses.Model
{
    public class Payment : Entity
    {
        public Guid? RecipientId { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime DateTime { get; private set; }

        protected Payment()
        {
        }

        public Payment(Guid id, Guid? recipientId, decimal amount, DateTime dateTime) : base(id)
        {
            RecipientId = recipientId;
            Amount = amount;
            DateTime = dateTime;
        }

        public Task ChangeRecipient(Guid? recipientId)
        {
            RecipientId = recipientId;

            return Task.CompletedTask;
        }

        public Task ChangePaymentData(decimal amount, DateTime dateTime)
        {
            Amount = amount;
            DateTime = dateTime;

            return Task.CompletedTask;
        }
    }
}