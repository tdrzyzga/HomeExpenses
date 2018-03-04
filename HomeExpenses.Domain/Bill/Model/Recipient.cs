using System;
using System.Threading.Tasks;
using Core.Domain.Entities;
using Core.Domain.ValueObjects;

namespace HomeExpenses.Domain.Bill.Model
{
    public class Recipient : Entity
    {
        public string Name { get; private set; }
        public AddressValueObject Address { get; private set; }

        protected Recipient()
        {
        }

        public Recipient(Guid id, string name, AddressValueObject address) : base(id)
        {
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