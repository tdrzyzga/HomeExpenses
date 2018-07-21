using System;
using Core.Message.Commands;

namespace HomeExpenses.Message.Expenses.Commands
{
    public class CreatePeriodicExpenseCommand : BaseCommand
    {
        public Guid Id { get; }
        public string Name { get; }
        public int DayOfMonth { get; }
        public int MonthInterval { get; }

        public CreatePeriodicExpenseCommand(Guid id, string name, int dayOfMonth, int monthInterval)
        {
            Id = id;
            Name = name;
            DayOfMonth = dayOfMonth;
            MonthInterval = monthInterval;
        }
    }
}