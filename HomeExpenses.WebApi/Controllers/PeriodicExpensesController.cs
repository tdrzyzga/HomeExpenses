using System;
using System.Threading.Tasks;
using Core.Akka.ActorSystem;
using HomeExpenses.Message.Expenses.Commands;
using HomeExpenses.WebApi.Infrastructure.Controller;
using Microsoft.AspNetCore.Mvc;

namespace HomeExpenses.WebApi.Controllers
{
    [Route("api/PeriodcExpenses")]
    public class PeriodicExpensesController : BaseController
    {
        public PeriodicExpensesController(IServiceProvider serviceProvider, ILocalActorSystemManager localActorSystemManager, ActorSystemConfiguration actorSystemConfiguration)
            : base(serviceProvider, localActorSystemManager, actorSystemConfiguration)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateExpense([FromBody] CreatePeriodicExpenseCommand command)
        {
            return await SendCommand(command);
        }

        [HttpPut]
        [Route("Payments")]
        public async Task<IActionResult> AddPayment([FromBody] AddPaymentCommand command)
        {
            return await SendCommand(command);
        }
    }
}