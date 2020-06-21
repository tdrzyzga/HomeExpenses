using System;

namespace Core.Domain.Entities
{
    public abstract class AggregateRoot : Entity
    {
        public DateTime CreatedOn { get; protected set; }
        public DateTime? ModifiedOn { get; protected set; }

        protected AggregateRoot()
        {
        }

        protected AggregateRoot(Guid id) : base(id)
        {
            CreatedOn = DateTime.UtcNow;
        }

        public void ModifyOn(DateTime dateTime)
        {
            ModifiedOn = dateTime;
        }
    }
}