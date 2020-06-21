using MediatR;

namespace Core.Message.Commands
{
    public interface ICommand : IRequest<ICommandResult>
    {
        Metadata Metadata { get; }
        void SetMetadata(Metadata metadata);
    }
}