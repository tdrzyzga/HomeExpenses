using Microsoft.AspNetCore.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class BaseController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IServiceProvider _serviceProvider;

        public BaseController(BaseControllerPayload payload)
        {
            _serviceProvider = payload.ServiceProvider;
        }


        private string GetCulture()
        {
            // using ASP.NET Core Localization and Request Culture Providers to retrieve requested culture
            var requestCultureFeature = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            return requestCultureFeature.RequestCulture.Culture.Name;
        }
    }
}
