using HomeExpenses.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeExpenses.Domain.Entities.Bill.Model
{
    public class Bill : AggregateRoot
    {
        public string Name { get; private set; }
        public decimal Amount { get; private set; }

        protected Bill()
        {
        }

        public Bill(Guid id, Guid creatorId, string name, decimal amount) : base(id, creatorId)
        {
            Name = name;
            Amount = amount;
        }

        public Task ChangeName(string name)
        {
            Name = name;

            return Task.CompletedTask;
        }

        public Task ChangeAmount(decimal amount)
        {
            Amount = amount;

            return Task.CompletedTask;
        }
    }
}
