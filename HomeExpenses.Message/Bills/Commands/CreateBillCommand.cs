using System;
using Core.Message.Command;

namespace HomeExpenses.Message.Bills.Commands
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