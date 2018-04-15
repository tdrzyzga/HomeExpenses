using System;
using System.Threading.Tasks;

namespace Core.Domain.Entities
{
    public abstract class AggregateRoot : Entity
    {
        public DateTime CreatedOn { get; protected set; }
        public DateTime? ModifiedOn { get; protected set; }
        public bool IsDeleted { get; protected set; }

        protected AggregateRoot()
        {
            IsDeleted = false;
        }

        protected AggregateRoot(Guid id, Guid creatorId) : base(id)
        {
            CreatedOn = DateTime.UtcNow;
            IsDeleted = false;
        }

        public void ModifyOn(DateTime dateTime)
        {
            ModifiedOn = dateTime;
        }

        public virtual Task DeleteAsync()
        {
            IsDeleted = true;
            return Task.CompletedTask;
        }
    }
}