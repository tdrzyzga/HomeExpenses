using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExpenses.Core.Entities
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
