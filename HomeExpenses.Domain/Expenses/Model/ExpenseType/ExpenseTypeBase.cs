using System;
using Core.Domain.Entity;

namespace HomeExpenses.Domain.Expenses.Model.ExpenseType
{
    public class ExpenseTypeBase : Entity
    {
        public Guid ExpenseId { get; private set; }
        public Expense Expense { get; private set; }

        protected ExpenseTypeBase()
        {
        }

        protected ExpenseTypeBase(Guid id) : base(id)
        {
        }
    }
}