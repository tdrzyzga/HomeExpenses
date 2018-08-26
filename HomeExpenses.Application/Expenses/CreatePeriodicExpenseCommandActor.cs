using System.Threading.Tasks;
using Core.Akka.ActorAutostart;
using Core.Application.Actors;
using Core.Domain.Repositories;
using HomeExpenses.Domain.Expenses.Factory;
using HomeExpenses.Domain.Expenses.Model;
using HomeExpenses.Message.Expenses.Commands;

namespace HomeExpenses.Application.Expenses
{
    [AutostartActor("CreatePeriodicExpenseCommandActor")]
    public class CreatePeriodicExpenseCommandActor : BaseActor
    {
        private readonly IExpenseFactory _expenseFactory;
        private readonly IRepository<Expense> _expenseRepository;

        public CreatePeriodicExpenseCommandActor(IBaseActorPayload payload, IRepository<Expense> expenseRepository, IExpenseFactory expenseFactory) :
            base(payload)
        {
            _expenseRepository = expenseRepository;
            _expenseFactory = expenseFactory;

            ReceiveAsync<CreatePeriodicExpenseCommand>(Handle);
        }

        private async Task Handle(CreatePeriodicExpenseCommand command)
        {
            await HandleCommand(command, async x =>
            {
                var expense = await _expenseFactory.Create(command.Id, command.Metadata.TenantId, command.Name);

                await expense.SetPeriodicExpenseType(command.DayOfMonth, command.MonthInterval);

                await _expenseRepository.Save(expense);
            });
        }
    }
}