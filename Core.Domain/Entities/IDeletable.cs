namespace Core.Domain.Entities
{
    public interface IDeletable
    {
        bool IsDeleted { get; }
    }
}