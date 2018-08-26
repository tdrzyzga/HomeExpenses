using System.Threading.Tasks;
using HomeExpenses.Message.Expenses.Commands;
using HomeExpenses.WebApi.Infrastructure.Controller;
using Microsoft.AspNetCore.Mvc;

namespace HomeExpenses.WebApi.Controllers
{
    [Route("api/PeriodcExpenses")]
    public class PeriodicExpensesController : BaseController
    {
        public PeriodicExpensesController(BaseControllerPayload payload) 
            : base(payload)
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