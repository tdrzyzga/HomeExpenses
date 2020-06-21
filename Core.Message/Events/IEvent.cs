using MediatR;

namespace Core.Message.Events
{
    public interface IEvent : INotification
    {
        Metadata Metadata { get; }
        void SetMetadata(Metadata metadata);
    }
}