using System.Threading.Tasks;
using Core.Akka.ActorAutostart;
using Core.Application.Actor;
using Core.Domain.Repository;
using Core.Domain.ValueObjects;
using HomeExpenses.Domain;
using HomeExpenses.Domain.Expenses.Factory;
using HomeExpenses.Domain.Expenses.Model;
using HomeExpenses.Message.Expenses.Commands;
using Microsoft.Extensions.Logging;

namespace HomeExpenses.Application.Expenses
{
    [AutostartActor("CreatePeriodicExpenseCommandActor")]
    public class CreatePeriodicExpenseCommandActor : BaseActor
    {
        private readonly IRepository<Expense> _billRepository;
        private readonly IExpenseFactory _expenseFactory;

        public CreatePeriodicExpenseCommandActor(ILogger<CreatePeriodicExpenseCommandActor> logger, IRepository<Expense> billRepository, IExpenseFactory expenseFactory) : base(logger)
        {
            _billRepository = billRepository;
            _expenseFactory = expenseFactory;

            ReceiveAsync<CreatePeriodicExpenseCommand>(Handle);
        }

        private async Task Handle(CreatePeriodicExpenseCommand command)
        {
            await HandleCommand(command, async x =>
            {
                var recipientAddress = new AddressValueObject(command.City, command.Street, command.Number);

                var bill = await _expenseFactory.Create(command.Id, command.Metadata.TenantId, command.Name);

                await _billRepository.SaveAsync(bill);
            });
        }
    }
}