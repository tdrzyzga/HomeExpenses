using MediatR;

namespace Core.Message.Commands
{
    public interface ICommand : IRequest<ICommandResponse>
    {
        Metadata Metadata { get; }

        void SetMetadata(Metadata metadata);
    }
}