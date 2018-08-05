using System;
using Microsoft.Extensions.Logging;

namespace Core.Application.Actors
{
    public class BaseActorPayload
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