using System.Collections.Generic;
using System.Threading.Tasks;
using HomeExpenses.Message.Expenses.Commands;
using HomeExpenses.WebApi.Infrastructure.Controller;
using Microsoft.AspNetCore.Mvc;

namespace HomeExpenses.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : BaseController
    {
        public ValuesController(BaseControllerPayload payload)
            : base(payload)
        {
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] {"value1", "value2"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePeriodicExpenseCommand command)
        {
            return await SendCommand(command);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}