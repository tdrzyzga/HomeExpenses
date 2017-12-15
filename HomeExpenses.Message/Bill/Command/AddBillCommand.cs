using Core.Message.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExpenses.Message.Bill.Command
{
    public class AddBillCommand : BaseCommand
    {
        public Guid Id { get; }
        public decimal Amount { get; }

        public AddBillCommand(Guid id, decimal amount)
        {
            Id = id;
            Amount = amount;
        }
    }
}
