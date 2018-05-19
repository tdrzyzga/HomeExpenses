using System;

namespace HomeExpenses.Domain.Expenses.Model.ExpenseType
{
    public class AperiodicExpenseType : ExpenseTypeBase
    {
        public string Description { get; private set; }

        protected AperiodicExpenseType()
        {
        }

        public AperiodicExpenseType(Guid id, string description) : base(id)
        {
            Description = description;
        }
    }
}