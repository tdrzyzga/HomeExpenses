using Core.Akka.ActorSystem;
using Core.Message;
using Core.Message.Command;
using HomeExpenses.WebApi.Infrastructure.Seed;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public class BaseController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILocalActorSystemManager _localActorSystemManager;

        public BaseController(IServiceProvider serviceProvider, ILocalActorSystemManager localActorSystemManager)
        {
            _serviceProvider = serviceProvider;
            _localActorSystemManager = localActorSystemManager;
        }


        protected async Task<IActionResult> SendCommand<TCommand>(string dispatcherActorName, TCommand command) where TCommand : ICommand
        {
            var culture = GetCulture();
            command.SetMetadata(new Metadata(culture, FakeSeedData.UserId));

            var actor = _localActorSystemManager.ActorSystem.

            return BadRequest();
        }


        private string GetCulture()
        {
            // using ASP.NET Core Localization and Request Culture Providers to retrieve requested culture
            var requestCultureFeature = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            return requestCultureFeature.RequestCulture.Culture.Name;
        }
    }
}
