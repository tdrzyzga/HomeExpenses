using System;
using System.Threading.Tasks;
using Core.Domain.ValueObjects;

namespace HomeExpenses.Domain.Expenses.Model.ExpenseType
{
    public class PeriodicExpenseType : ExpenseTypeBase
    {
        public int DayOfMonth { get; private set; }
        public int MonthInterval { get; private set; }
        public Recipient Recipient { get; private set; }

        protected PeriodicExpenseType()
        {
        }

        public PeriodicExpenseType(Guid id, int dayOfMonth, int monthInterval, Recipient recipient) : base(id)
        {
            DayOfMonth = dayOfMonth;
            MonthInterval = monthInterval;
            Recipient = recipient;
        }
        
        public Task ChangePaymentPeriod(int dayOfMonth, int monthInterval)
        {
            DayOfMonth = dayOfMonth;
            MonthInterval = monthInterval;

            return Task.CompletedTask;
        }

        public Task ChangeRecipient(string name, AddressValueObject address)
        {
            Recipient.ChangeName(name);
            Recipient.ChangeAddress(address);

            return Task.CompletedTask;
        }
    }
}