using System;

namespace Core.Message.Events
{
    public class BaseEvent : IEvent
    {
        public Metadata Metadata { get; }

        public void SetMetadata(Metadata metadata)
        {
            throw new NotImplementedException();
        }
    }
}