using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain.Entity;
using Core.Domain.ValueObjects;
using HomeExpenses.Domain.Expenses.Exceptions;
using HomeExpenses.Domain.Expenses.Model.ExpenseType;

namespace HomeExpenses.Domain.Expenses.Model
{
    public class Expense : AggregateRoot, IHaveTenant
    {
        public Guid? TenantId { get; private set; }
        public string Name { get; private set; }
        public ExpenseTypeBase ExpenseType { get; private set; }
        public ICollection<Payment> Payments { get; private set; }

        protected Expense()
        {
        }

        public Expense(Guid id, Guid? tenantId, string name, ExpenseTypeBase expenseType, ICollection<Payment> payments) : base(id)
        {
            TenantId = tenantId;
            Name = name;
            ExpenseType = expenseType;
            Payments = payments;
        }

        public Task ChangeName(string name)
        {
            Name = name;

            return Task.CompletedTask;
        }

        public Task SetExpenseType(ExpenseTypeBase expenseType)
        {
            if (ExpenseType != null)
            {
                throw new ExpenseTypeAlreadyExistException();
            }

            ExpenseType = expenseType;

            return Task.CompletedTask;
        }

        public Task AddPayment(decimal amount, DateTime dateTime)
        {
            Payments.Add(new Payment(Guid.NewGuid(), amount, dateTime));

            return Task.CompletedTask;
        }
    }
}