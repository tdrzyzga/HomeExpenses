using System;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Akka.ActorSystem;
using Core.Message;
using Core.Message.Commands;
using Core.Message.Queries;
using HomeExpenses.WebApi.Infrastructure.Seed;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public abstract class BaseController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ActorSystemConfiguration _actorSystemConfiguration;
        private readonly ILocalActorSystemManager _localActorSystemManager;

        protected BaseController(BaseControllerPayload payload)
        {
            _localActorSystemManager = payload.LocalActorSystemManager;
            _actorSystemConfiguration = payload.ActorSystemConfiguration;
        }

        protected async Task<IActionResult> SendCommand<TCommand>(TCommand command) where TCommand : ICommand
        {
            var culture = GetCulture();
            command.SetMetadata(new Metadata(culture, FakeSeedData.TenantId));
            string path = $"{_actorSystemConfiguration.Path}{typeof(TCommand).Name}Actor";

            var actor = await _localActorSystemManager.ActorSystem.ActorSelection(path).ResolveOne(TimeSpan.FromSeconds(30));
            var response = await actor.Ask(command);

            switch (response)
            {
                case CommandErrorResponse errorResponse:
                    return BadRequest(errorResponse);
                case CommandSuccessResponse _:
                    return Ok();
                default:
                    return BadRequest();
            }
        }

        protected async Task<IActionResult> SendQuery<TQuery>(TQuery query) where TQuery : IQuery
        {
            var culture = GetCulture();
            query.SetMetadata(new Metadata(culture, FakeSeedData.TenantId));
            string path = $"{_actorSystemConfiguration.Path}{typeof(TQuery).Name}Actor";

            var actor = await _localActorSystemManager.ActorSystem.ActorSelection(path).ResolveOne(TimeSpan.FromSeconds(30));
            var result = await actor.Ask(query);

            switch (result)
            {
                case null:
                    return NotFound();
                case QueryErrorResult errorResponse:
                    return BadRequest(errorResponse);
                default:
                    return Ok(result);
            }
        }


        private string GetCulture()
        {
            // using ASP.NET Core Localization and Request Culture Providers to retrieve requested culture
            var requestCultureFeature = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            return requestCultureFeature.RequestCulture.Culture.Name;
        }
    }
}