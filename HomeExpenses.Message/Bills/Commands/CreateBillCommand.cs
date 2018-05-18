using System;
using Core.Message.Command;

namespace HomeExpenses.Message.Bills.Commands
{
    public class CreateBillCommand : BaseCommand
    {
        public Guid Id { get; }
        public string Name { get; }
        public BillType Type { get; }
        public string RecipientName { get; }
        public string City { get; }
        public string Street { get; }
        public string Number { get; }

        public CreateBillCommand(Guid id, string name, BillType type, string recipientName, string city, string street, string number)
        {
            Id = id;
            Name = name;
            Type = type;
            RecipientName = recipientName;
            City = city;
            Street = street;
            Number = number;
        }
    }
}