using Core.Application.Handlers;
using Core.Domain.Repositories;
using Core.Domain.ValueObjects;
using HomeExpenses.Domain.Recipients.Factory;
using HomeExpenses.Domain.Recipients.Model;
using HomeExpenses.Message.Recipients.Commands;
using System;
using System.Threading.Tasks;
using Core.Application.MessageBus;
using HomeExpenses.Message.Recipients.Events;

namespace HomeExpenses.Application.Recipients.CommandHandlers
{
    public class CreateRecipientCommandHandler : ICommandHandler<CreateRecipientCommand>
    {
        private readonly IRecipientFactory _recipientFactory;
        private readonly IRepository<Recipient> _recipientRepository;
        private readonly IApplicationMessageBus _messageBus;

        public CreateRecipientCommandHandler(IRecipientFactory recipientFactory, IRepository<Recipient> recipientRepository, IApplicationMessageBus messageBus)
        {
            _recipientFactory = recipientFactory;
            _recipientRepository = recipientRepository;
            _messageBus = messageBus;
        }

        public async Task Handle(CreateRecipientCommand command)
        {
            var address = new AddressValueObject(command.City, command.Street, command.Number);

            var recipient = await _recipientFactory.Create(Guid.NewGuid(), command.Metadata.TenantId, command.Name, address);

            await _recipientRepository.Save(recipient);

            await _messageBus.SendEvent(new RecipientCreatedEvent(recipient.Id, recipient.Name));
        }
    }
}