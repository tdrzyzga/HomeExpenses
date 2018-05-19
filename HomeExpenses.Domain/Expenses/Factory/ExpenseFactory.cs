using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeExpenses.Domain.Expenses.Model;

namespace HomeExpenses.Domain.Expenses.Factory
{
    public interface IExpenseFactory
    {
        Task<Expense> Create(Guid id, Guid? tenantId, string name);
    }

    public class ExpenseFactory : IExpenseFactory
    {
        public Task<Expense> Create(Guid id, Guid? tenantId, string name)
        {
            var expense = new Expense(id,
                                      tenantId,
                                      name,
                                      null,
                                      new List<Payment>());

            return Task.FromResult(expense);
        }
    }
}