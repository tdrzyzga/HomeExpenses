namespace Core.Message.Queries
{
    public abstract class BaseQuery : IQuery
    {
        public Metadata Metadata { get; set; }

        public virtual void SetMetadata(Metadata metadata)
        {
            Metadata = metadata;
        }
    }
}