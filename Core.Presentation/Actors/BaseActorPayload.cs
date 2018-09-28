using System;
using Microsoft.Extensions.Logging;

namespace Core.Presentation.Actors
{
    public interface IBaseActorPayload
    {
        ILogger Logger { get; }
    }

    public class BaseActorPayload : IBaseActorPayload
    {
        public ILogger Logger { get; }

        public BaseActorPayload(ILogger<BaseActor> logger)
        {
            Logger = logger;
        }
    }
}