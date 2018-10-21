using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Akka.ActorSystem;
using Core.Application.Actors;
using Core.Message;
using Core.Message.Commands;
using Core.Message.Queries;
using FluentValidation;
using FluentValidation.Results;
using HomeExpenses.WebApi.Infrastructure.Seed;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public abstract class BaseController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly CommandForwarderActorProvider _commandForwarderActorProvider;

        protected BaseController(BaseControllerPayload payload)
        {
            _commandForwarderActorProvider = payload.CommandForwarderActorProvider;
            _serviceProvider = payload.ServiceProvider;
        }

        protected async Task<IActionResult> SendCommand<TCommand>(TCommand command) where TCommand : ICommand
        {
            var validationErrors = await Validate(command);

            if (validationErrors != null && validationErrors.Any())
            {
                foreach (var validationError in validationErrors)
                {
                    ModelState.AddModelError(validationError.PropertyName, validationError.ErrorMessage);
                }

                return BadRequest(ModelState);
            }

            var culture = GetCulture();
            command.SetMetadata(new Metadata(culture, FakeSeedData.TenantId));

            var response = await _commandForwarderActorProvider.CommandForwarderActor.Ask(command);

            switch (response)
            {
                case ValidationErrorResponse validationErrorResponse:
                {
                    foreach (var validationError in validationErrorResponse.Errors)
                    {
                        ModelState.AddModelError(validationError.Key, validationError.Value);
                    }

                    return BadRequest(ModelState);
                }
                case CommandErrorResponse errorResponse:
                    return BadRequest(errorResponse);
                case CommandSuccessResponse _:
                    return Ok();
                default:
                    return BadRequest();
            }
        }

        protected async Task SendQuery<TQuery>(TQuery query) where TQuery : IQuery
        {
//            var culture = GetCulture();
//            query.SetMetadata(new Metadata(culture, FakeSeedData.TenantId));
//            string path = $"{_actorSystemConfiguration.Path}{typeof(TQuery).Name}Actor";
//
//            var actor = await _localActorSystemManager.ActorSystem.ActorSelection(path).ResolveOne(TimeSpan.FromSeconds(30));
//            var result = await actor.Ask(query);
//
//            switch (result)
//            {
//                case null:
//                    return NotFound();
//                case QueryErrorResult errorResponse:
//                    return BadRequest(errorResponse);
//                default:
//                    return Ok(result);
//            }
        }

        private string GetCulture()
        {
            // using ASP.NET Core Localization and Request Culture Providers to retrieve requested culture
            var requestCultureFeature = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            return requestCultureFeature.RequestCulture.Culture.Name;
        }

        private async Task<ICollection<ValidationFailure>> Validate<TCommand>(TCommand command) where TCommand : ICommand
        {
            var validator = _serviceProvider.GetService<IValidator<TCommand>>();
            if (validator == null)
                return null;

            var result = await validator.ValidateAsync(command);
            return result.Errors;
        }
    }
}