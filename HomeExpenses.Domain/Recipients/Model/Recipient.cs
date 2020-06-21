using System;
using Core.Domain.Entities;
using Core.Domain.ValueObjects;

namespace HomeExpenses.Domain.Recipients.Model
{
    public class Recipient : AggregateRoot, IHaveTenant, IDeletable
    {
        public Guid? TenantId { get; private set; }
        public bool IsDeleted { get; private set; }
        public string Name { get; private set; }
        public virtual AddressValueObject Address { get; private set; }

        protected Recipient()
        {
        }

        public Recipient(Guid id, Guid? tenantId, string name, AddressValueObject address) : base(id)
        {
            TenantId = tenantId;
            Name = name;
            Address = new AddressValueObject(address);
        }

        public void ChangeName(string name)
        {
            Name = name;
        }

        public void ChangeAddress(AddressValueObject address)
        {
            Address = new AddressValueObject(address);
        }

        public virtual void Delete()
        {
            IsDeleted = true;
        }
    }
}