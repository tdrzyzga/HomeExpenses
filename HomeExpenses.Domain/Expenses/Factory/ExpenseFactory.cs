using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain.ValueObjects;
using HomeExpenses.Domain.Bills.Model;

namespace HomeExpenses.Domain.Bills.Factory
{
    public interface IExpenseFactory
    {
        Task<Expense> Create(Guid id, Guid? tenantId, string name, BillType type, string recipientName, AddressValueObject recipientAddress);
    }

    public class ExpenseFactory : IExpenseFactory
    {
        public Task<Expense> Create(Guid id, Guid? tenantId, string name, BillType type, string recipientName, AddressValueObject recipientAddress)
        {
            var bill = new Expense(id,
                                tenantId, 
                                name, 
                                type, 
                                null, 
                                null, 
                                new Recipient(Guid.NewGuid(), recipientName, recipientAddress), 
                                new List<Payment>());

            return Task.FromResult(bill);
        }
    }
}