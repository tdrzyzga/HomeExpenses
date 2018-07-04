using System;
using System.Threading.Tasks;
using Core.Akka.ActorSystem;
using HomeExpenses.Message.Recipients.Commands;
using HomeExpenses.WebApi.Infrastructure.Controller;
using Microsoft.AspNetCore.Mvc;

namespace HomeExpenses.WebApi.Controllers
{
    [Route("api/Recipients")]
    public class RecipientsController : BaseController
    {
        public RecipientsController(IServiceProvider serviceProvider, ILocalActorSystemManager localActorSystemManager, ActorSystemConfiguration actorSystemConfiguration)
            : base(serviceProvider, localActorSystemManager, actorSystemConfiguration)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecipient([FromBody] CreateRecipientCommand command)
        {
            return await SendCommand(command);
        }
    }
}