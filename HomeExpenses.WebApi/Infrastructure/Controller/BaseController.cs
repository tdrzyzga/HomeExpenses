using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Application.MessageBus;
using Core.Message;
using Core.Message.Commands;
using Core.Message.Queries;
using Core.Presentation.MessageBus;
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
        private readonly IApplicationMessageBus _applicationMessageBus;
        private readonly IPresentationMessageBus _presentationMessageBus;

        protected BaseController(BaseControllerPayload payload)
        {
            _serviceProvider = payload.ServiceProvider;
            _applicationMessageBus = payload.ApplicationMessageBus;
            _presentationMessageBus = payload.PresentationMessageBus;
        }

        protected async Task<IActionResult> SendCommand<TCommand>(TCommand command) where TCommand : class, ICommand
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

            var result = await _applicationMessageBus.SendCommand(command);

            switch (result)
            {
                case ValidationErrorResult validationErrorResult:
                    {
                        foreach (var validationError in validationErrorResult.Errors)
                        {
                            ModelState.AddModelError(validationError.Key, validationError.Value);
                        }

                        return BadRequest(ModelState);
                    }
                case CommandErrorResult errorResult:
                    return BadRequest(errorResult);
                case CommandSuccessResult _:
                    return Ok();
                default:
                    return BadRequest();
            }
        }

        protected async Task<IActionResult> SendQuery<TQuery>(TQuery query) where TQuery : class, IQuery
        {
            var culture = GetCulture();
            query.SetMetadata(new Metadata(culture, FakeSeedData.TenantId));

            var result = await _presentationMessageBus.SendQuery(query);

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