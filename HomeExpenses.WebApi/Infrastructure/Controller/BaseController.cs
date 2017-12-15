using Core.Akka.ActorSystem;
using Akka.Actor;
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
    public abstract class BaseController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IRemoteActorProvider _remoteActorProvider;

        protected BaseController(IServiceProvider serviceProvider, IRemoteActorProvider remoteActorProvider)
        {
            _serviceProvider = serviceProvider;
            _remoteActorProvider = remoteActorProvider;
        }

        protected async Task<IActionResult> SendCommand<TCommand>(string dispatcherActorName, TCommand command) where TCommand : ICommand
        {
            var culture = GetCulture();
            command.SetMetadata(new Metadata(culture, FakeSeedData.UserId));

            var actor = await _remoteActorProvider.GetOne(dispatcherActorName);
            var response = await actor.Ask(command);

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
