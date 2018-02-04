using Core.Domain.Entities;
using Core.Domain.ValueObjects;

namespace HomeExpenses.Domain.Bill
{
    public class Recipient : Entity
    {
        public string Name { get; private set; }
        public AddressValueObject Address { get; private set; }
    }
}