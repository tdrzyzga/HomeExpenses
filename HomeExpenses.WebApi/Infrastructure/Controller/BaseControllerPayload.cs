using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class BaseControllerPayload
    {
        public IServiceProvider ServiceProvider { get; }

        public BaseControllerPayload(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
    }
}
