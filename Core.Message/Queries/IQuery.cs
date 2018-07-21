namespace Core.Message.Queries
{
    public interface IQuery
    {
        Metadata Metadata { get; }

        void SetMetadata(Metadata metadata);
    }
}