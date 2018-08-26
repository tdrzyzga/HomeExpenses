using System;
using Core.Domain.Entities;

namespace HomeExpenses.Domain.Expenses.Model.ExpenseType
{
    public class ExpenseTypeBase : Entity
    {
        public Expense Expense { get; private set; }

        protected ExpenseTypeBase()
        {
        }

        protected ExpenseTypeBase(Guid id) : base(id)
        {
        }
    }
}