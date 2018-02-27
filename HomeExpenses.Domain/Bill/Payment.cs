using System;
using Core.Domain.Entities;

namespace HomeExpenses.Domain.Bill
{
    public class Payment : Entity
    {
        public DateTime DateTime { get; private set; }

        public decimal Amount { get; private set; }

        protected Payment()
        {
        }

        public Payment(Guid id, DateTime dateTime, decimal amount) : base(id)
        {
            DateTime = dateTime;
            Amount = amount;
        }
    }
}