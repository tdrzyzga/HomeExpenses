using System;
using System.Threading.Tasks;
using Core.Domain.Entity;
using Core.Domain.ValueObjects;

namespace HomeExpenses.Domain.Recipients.Model
{
    public class Recipient : AggregateRoot, IHaveTenant
    {
        public Guid? TenantId { get; }
        public string Name { get; private set; }
        public AddressValueObject Address { get; private set; }

        protected Recipient()
        {
        }

        public Recipient(Guid id, Guid? tenantId, string name, AddressValueObject address) : base(id)
        {
            TenantId = tenantId;
            Name = name;
            Address = new AddressValueObject(address);
        }

        public Task ChangeName(string name)
        {
            Name = name;

            return Task.CompletedTask;
        }

        public Task ChangeAddress(AddressValueObject address)
        {
            Address = new AddressValueObject(address);

            return Task.CompletedTask;
            ;
        }
    }
}