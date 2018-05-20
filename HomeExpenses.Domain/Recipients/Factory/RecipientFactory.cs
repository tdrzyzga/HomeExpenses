using System;
using System.Threading.Tasks;
using Core.Domain.ValueObjects;
using HomeExpenses.Domain.Recipients.Model;

namespace HomeExpenses.Domain.Recipients.Factory
{
    public interface IRecipientFactory
    {
        Task<Recipient> Create(Guid id, Guid? tenantId, string name, AddressValueObject address);
    }

    public class RecipientFactory : IRecipientFactory
    {
        public Task<Recipient> Create(Guid id, Guid? tenantId, string name, AddressValueObject address)
        {
            var recipient = new Recipient(id, tenantId, name, address);

            return Task.FromResult(recipient);
        }
    }
}