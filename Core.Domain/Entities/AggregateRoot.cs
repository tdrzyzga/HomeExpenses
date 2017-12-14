using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Entities
{
    public abstract class AggregateRoot : Entity
    {
        public Guid CreatorId { get; protected set; }
        public DateTime CreatedOn { get; protected set; }
        public DateTime? ModifiedOn { get; protected set; }
        public bool IsDeleted { get; protected set; }

        protected AggregateRoot()
        {
            IsDeleted = false;
        }

        protected AggregateRoot(Guid id, Guid creatorId) : base(id)
        {
            CreatorId = creatorId;
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
