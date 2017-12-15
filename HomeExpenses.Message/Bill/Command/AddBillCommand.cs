using Core.Message.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExpenses.Message.Bill.Command
{
    public class AddBillCommand : BaseCommand
    {
        public Guid Id { get; }
        public string Name { get; }
        public decimal Amount { get; }

        public AddBillCommand(Guid id, string name, decimal amount)
        {
            Id = id;
            Name = name;
            Amount = amount;
        }
    }
}
