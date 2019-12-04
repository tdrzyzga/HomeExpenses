using Core.Application.Handlers;
using Core.Domain.Repositories;
using Core.Domain.ValueObjects;
using HomeExpenses.Domain.Recipients.Model;
using HomeExpenses.Message.Recipients.Commands;
using System.Threading.Tasks;

namespace HomeExpenses.Application.Recipients.CommandHandlers
{
    public class UpdateRecipientCommandActor : ICommandHandler<UpdateRecipientCommand>
    {
        private readonly IRepository<Recipient> _recipientRepository;

        public async Task Handle(UpdateRecipientCommand command)
        {
            var recipient = await _recipientRepository.Get(command.Id, command.Metadata.TenantId);

            var address = new AddressValueObject(command.City, command.Street, command.Number);

            await recipient.ChangeName(command.Name);
            await recipient.ChangeAddress(address);

            await _recipientRepository.Save(recipient);
        }
    }
}