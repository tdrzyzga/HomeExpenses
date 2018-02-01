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
using Core.Message.Response;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public abstract class BaseController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILocalActorSystemManager _localActorSystemManager;

        protected BaseController(IServiceProvider serviceProvider, ILocalActorSystemManager localActorSystemManager)
        {
            _serviceProvider = serviceProvider;
            _localActorSystemManager = localActorSystemManager;
        }

        protected async Task<IActionResult> SendCommand<TCommand>(string dispatcherActorName, TCommand command) where TCommand : ICommand
        {
            var culture = GetCulture();
            command.SetMetadata(new Metadata(culture, FakeSeedData.UserId));
            string path = $"akka.tcp://HostActorSystem@localhost:9991/user/{dispatcherActorName}";

            var actor = await _localActorSystemManager.ActorSystem.ActorSelection(path).ResolveOne(TimeSpan.FromSeconds(30));
            var response = await actor.Ask(command);

            if (response == null)
                return NotFound();
            if (response is ErrorResponse)
                return BadRequest();
            if (response is CommandSuccessResponse)
                return Ok();

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
