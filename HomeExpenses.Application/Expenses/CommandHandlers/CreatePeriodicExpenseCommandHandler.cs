using Core.Application.Handlers;
using Core.Domain.Repositories;
using HomeExpenses.Domain.Expenses.Factory;
using HomeExpenses.Domain.Expenses.Model;
using HomeExpenses.Message.Expenses.Commands;
using System.Threading.Tasks;

namespace HomeExpenses.Application.Expenses.CommandHandlers
{
    public class CreatePeriodicExpenseCommandHandler : ICommandHandler<CreatePeriodicExpenseCommand>
    {
        private readonly IExpenseFactory _expenseFactory;
        private readonly IRepository<Expense> _expenseRepository;

        public CreatePeriodicExpenseCommandHandler(IExpenseFactory expenseFactory, IRepository<Expense> expenseRepository)
        {
            _expenseFactory = expenseFactory;
            _expenseRepository = expenseRepository;
        }

        public async Task Handle(CreatePeriodicExpenseCommand command)
        {
            var expense = await _expenseFactory.Create(command.Id, command.Metadata.TenantId, command.Name);

            await expense.SetPeriodicExpenseType(command.DayOfMonth, command.MonthInterval);

            await _expenseRepository.Save(expense);
        }
    }
}