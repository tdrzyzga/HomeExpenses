using System;
using Microsoft.Extensions.Logging;

namespace Core.Application.Actors
{
    public interface IBaseActorPayload
    {
        ILogger Logger { get; }
        IServiceProvider ServiceProvider { get; }
    }

    public class BaseActorPayload : IBaseActorPayload
    {
        public ILogger Logger { get; }
        public IServiceProvider ServiceProvider { get; }

        public BaseActorPayload(ILogger logger, IServiceProvider serviceProvider)
        {
            Logger = logger;
            ServiceProvider = serviceProvider;
        }
    }
}