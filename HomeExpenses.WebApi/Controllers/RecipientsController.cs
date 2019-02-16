using System;
using System.Threading.Tasks;
using HomeExpenses.Message.Recipients.Commands;
using HomeExpenses.Message.Recipients.Queries;
using HomeExpenses.WebApi.Infrastructure.Controller;
using Microsoft.AspNetCore.Mvc;

namespace HomeExpenses.WebApi.Controllers
{
    [Route("api/recipients")]
    public class RecipientsController : BaseController
    {
        public RecipientsController(BaseControllerPayload payload)
            : base(payload)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecipient([FromBody] CreateRecipientCommand command)
        {
            return await SendCommand(command);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRecipient([FromBody] UpdateRecipientCommand command)
        {
            return await SendCommand(command);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetRecipient(Guid id)
        {
            var query = new GetRecipientDetailsQuery(id);
            return await SendQuery(query);
        }
    }
}