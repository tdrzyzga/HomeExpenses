using Akka.Actor;
using Microsoft.Extensions.Logging;

namespace Core.Application.Actor
{
    public class BaseActor : ReceiveActor
    {
        private readonly ILogger _logger;

        public BaseActor(ILogger logger)
        {
            _logger = logger;
        }
    }
}