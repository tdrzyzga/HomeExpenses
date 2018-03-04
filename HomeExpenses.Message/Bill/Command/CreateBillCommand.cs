using Core.Message.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExpenses.Message.Bill.Command
{
    public class CreateBillCommand : BaseCommand
    {
        public Guid Id { get; }
        public string Name { get; }

        public CreateBillCommand(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
