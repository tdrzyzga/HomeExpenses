using Core.Application.Handlers;
using Core.Domain.Repositories;
using HomeExpenses.Domain.Expenses.Model;
using HomeExpenses.Message.Expenses.Commands;
using System;
using System.Threading.Tasks;

namespace HomeExpenses.Application.Expenses.CommandHandlers
{
    public class AddPaymentCommandHandler : ICommandHandler<AddPaymentCommand>
    {
        private readonly IRepository<Expense> _expenseRepository;

        public AddPaymentCommandHandler(IRepository<Expense> expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task Handle(AddPaymentCommand command)
        {
            var expense = await _expenseRepository.Get(command.ExpenseId, command.Metadata.TenantId);

            await expense.AddPayment(command.RecipientId, command.Amount, DateTime.UtcNow);

            await _expenseRepository.Save(expense);
        }
    }
}