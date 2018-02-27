using System;
using Core.Domain.Entities;

namespace HomeExpenses.Domain.Bill
{
    public class Payment : Entity
    {
        public decimal Amount { get; private set; }
        public DateTime DateTime { get; private set; }

        protected Payment()
        {
        }

        public Payment(Guid id, decimal amount, DateTime dateTime) : base(id)
        {
            Amount = amount;
            DateTime = dateTime;
        }
    }
}