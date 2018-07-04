using System;
using Core.Message.Command;

namespace HomeExpenses.Message.Expenses.Commands
{
    public class AddPaymentCommand : BaseCommand
    {
        public Guid Id { get; }
        public Guid ExpenseId { get; }
        public Guid? RecipientId { get; }
        public decimal Amount { get; }

        public AddPaymentCommand(Guid id, Guid expenseId, Guid? recipientId, decimal amount)
        {
            Id = id;
            ExpenseId = expenseId;
            RecipientId = recipientId;
            Amount = amount;
        }
    }
}