using MediatR;

namespace Core.Message.Queries
{
    public interface IQuery : IRequest<IQueryResult>
    {
        Metadata Metadata { get; }
        void SetMetadata(Metadata metadata);
    }
}