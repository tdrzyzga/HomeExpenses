using System;
using Core.Message.Command;

namespace HomeExpenses.Message.Expenses.Commands
{
    public class CreatePeriodicExpenseCommand : BaseCommand
    {
        public Guid Id { get; }
        public string Name { get; }
        public int DayOfMonth { get; }
        public int MonthInterval { get; }
        public string RecipientName { get; }
        public string City { get; }
        public string Street { get; }
        public string Number { get; }

        public CreatePeriodicExpenseCommand(Guid id, string name, int dayOfMonth, int monthInterval, string recipientName, string city, string street, string number)
        {
            Id = id;
            Name = name;
            DayOfMonth = dayOfMonth;
            MonthInterval = monthInterval;
            RecipientName = recipientName;
            City = city;
            Street = street;
            Number = number;
        }
    }
}