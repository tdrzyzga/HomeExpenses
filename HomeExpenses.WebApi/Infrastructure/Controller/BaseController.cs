﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Application.MessageBus;
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
        private readonly IApplicationMessageBus _applicationMessageBus;

        protected BaseController(BaseControllerPayload payload)
        {
            _serviceProvider = payload.ServiceProvider;
            _applicationMessageBus = payload.ApplicationMessageBus;
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

            var response = await _applicationMessageBus.SendCommand(command);

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

        protected async Task<IActionResult> SendQuery<TQuery>(TQuery query) where TQuery : IQuery
        {
            //var culture = GetCulture();
            //query.SetMetadata(new Metadata(culture, FakeSeedData.TenantId));

            //var result = await _queryForwarderActorProvider.Ask(query);

            //switch (result)
            //{
            //    case null:
            //        return NotFound();
            //    case QueryErrorResult errorResponse:
            //        return BadRequest(errorResponse);
            //    default:
            //        return Ok(result);
            //}

            return NotFound();
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