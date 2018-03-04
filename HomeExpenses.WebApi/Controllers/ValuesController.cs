using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Akka.ActorSystem;
using HomeExpenses.Message.Bill.Command;
using HomeExpenses.WebApi.Infrastructure.Controller;
using Microsoft.AspNetCore.Mvc;

namespace HomeExpenses.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : BaseController
    {
        public ValuesController(IServiceProvider serviceProvider, ILocalActorSystemManager localActorSystemManager) : base(serviceProvider, localActorSystemManager)
        {
        }


        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateBillCommand command)
        {
            return await SendCommand("BillCommandActor", command);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
