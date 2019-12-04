using System;

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