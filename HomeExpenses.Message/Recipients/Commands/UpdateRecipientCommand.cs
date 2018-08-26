using System;
using Core.Message.Commands;

namespace HomeExpenses.Message.Recipients.Commands
{
    public class UpdateRecipientCommand : BaseCommand
    {
        public Guid Id { get; }
        public string Name { get; }
        public string City { get; }
        public string Street { get; }
        public string Number { get; }

        public UpdateRecipientCommand(Guid id, string name, string city, string street, string number)
        {
            Id = id;
            Name = name;
            City = city;
            Street = street;
            Number = number;
        }
    }
}