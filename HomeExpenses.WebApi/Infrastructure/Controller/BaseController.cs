using System;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Akka.ActorSystem;
using Core.Message;
using Core.Message.Command;
using Core.Message.Response;
using HomeExpenses.WebApi.Infrastructure.Seed;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public abstract class BaseController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILocalActorSystemManager _localActorSystemManager;
        private readonly ActorSystemConfiguration _actorSystemConfiguration;
        private readonly IServiceProvider _serviceProvider;

        protected BaseController(IServiceProvider serviceProvider, ILocalActorSystemManager localActorSystemManager, ActorSystemConfiguration actorSystemConfiguration)
        {
            _serviceProvider = serviceProvider;
            _localActorSystemManager = localActorSystemManager;
            _actorSystemConfiguration = actorSystemConfiguration;
        }

        protected async Task<IActionResult> SendCommand<TCommand>(TCommand command) where TCommand : ICommand
        {
            var culture = GetCulture();
            command.SetMetadata(new Metadata(culture, FakeSeedData.TenantId));
            string path = $"{_actorSystemConfiguration.Path}{typeof(TCommand).Name}Actor";

            var actor = await _localActorSystemManager.ActorSystem.ActorSelection(path).ResolveOne(TimeSpan.FromSeconds(30));
            var response = await actor.Ask(command);

            if (response == null)
                return NotFound();
            if (response is ErrorResponse errorResponse)
                return BadRequest(errorResponse);
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