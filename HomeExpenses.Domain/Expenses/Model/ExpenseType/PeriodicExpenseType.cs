using System;
using System.Threading.Tasks;

namespace HomeExpenses.Domain.Expenses.Model.ExpenseType
{
    public class PeriodicExpenseType : ExpenseTypeBase
    {
        public int DayOfMonth { get; private set; }
        public int MonthInterval { get; private set; }

        protected PeriodicExpenseType()
        {
        }

        public PeriodicExpenseType(Guid id, int dayOfMonth, int monthInterval) : base(id)
        {
            DayOfMonth = dayOfMonth;
            MonthInterval = monthInterval;
        }

        public Task ChangePaymentPeriod(int dayOfMonth, int monthInterval)
        {
            DayOfMonth = dayOfMonth;
            MonthInterval = monthInterval;

            return Task.CompletedTask;
        }
    }
}