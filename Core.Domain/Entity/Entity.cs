using System;

namespace Core.Domain.Entity
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        protected Entity()
        {
        }

        protected Entity(Guid id)
        {
            Id = id;
        }
    }
}