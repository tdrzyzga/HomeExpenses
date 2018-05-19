using System;
using Core.Domain.Entity;

namespace HomeExpenses.Domain.Expenses.Model.ExpenseType
{
    public class ExpenseTypeBase : Entity
    {
        protected ExpenseTypeBase()
        {
        }

        protected ExpenseTypeBase(Guid id) : base(id)
        {
        }
    }
}