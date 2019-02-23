using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain.Entities;
using HomeExpenses.Domain.Expenses.Exceptions;
using HomeExpenses.Domain.Expenses.Model.ExpenseType;

namespace HomeExpenses.Domain.Expenses.Model
{
    public class Expense : AggregateRoot, IHaveTenant
    {
        public Guid? TenantId { get; private set; }
        public string Name { get; private set; }
        public virtual ExpenseTypeBase ExpenseType { get; private set; }
        public virtual ICollection<Payment> Payments { get; private set; }

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

        public Task SetPeriodicExpenseType(int dayOfMonth, int monthInterval)
        {
            if (ExpenseType != null)
            {
                throw new ExpenseTypeAlreadyExistException();
            }

            ExpenseType = new PeriodicExpenseType(Guid.NewGuid(), dayOfMonth, monthInterval);

            return Task.CompletedTask;
        }

        public Task EditPeriodicExpenseType(int dayOfMonth, int monthInterval)
        {
            if (!(ExpenseType is PeriodicExpenseType type))
            {
                throw new InvalidOperationInThisExpenseTypeException();
            }

            type.ChangePaymentPeriod(dayOfMonth, monthInterval);

            return Task.CompletedTask;
        }

        public Task AddPayment(Guid? recipientId, decimal amount, DateTime dateTime)
        {
            Payments.Add(new Payment(Guid.NewGuid(), recipientId, amount, dateTime));

            return Task.CompletedTask;
        }

        public Task EditPayment(Guid paymentId, Guid? recipientId, decimal amount, DateTime dateTime)
        {
            var payment = Payments.SingleOrDefault(x => x.Id == paymentId);

            if (payment == null)
            {
                //todo throw exception
            }

            payment.ChangeRecipient(recipientId);
            payment.ChangePaymentData(amount, dateTime);

            return Task.CompletedTask;
        }

        public Task DeletePayment(Guid paymentId)
        {
            var payment = Payments.SingleOrDefault(x => x.Id == paymentId);

            if (payment != null)
            {
                Payments.Remove(payment);
            }

            return Task.CompletedTask;
        }

        public override async Task Delete()
        {
            await base.Delete();
        }
    }
}