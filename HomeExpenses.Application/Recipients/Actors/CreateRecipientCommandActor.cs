using System;
using System.Threading.Tasks;
using Core.Akka.ActorAutostart;
using Core.Application.Actors;
using Core.Domain.Repositories;
using Core.Domain.ValueObjects;
using HomeExpenses.Domain.Recipients.Factory;
using HomeExpenses.Domain.Recipients.Model;
using HomeExpenses.Message.Recipients.Commands;

namespace HomeExpenses.Application.Recipients.Actors
{
    [AutostartActor("CreateRecipientCommandActor")]
    public class CreateRecipientCommandActor : BaseActor, ICommandActor<CreateRecipientCommand>
    {
        private readonly IRecipientFactory _recipientFactory;
        private readonly IRepository<Recipient> _recipientRepository;

        public CreateRecipientCommandActor(IBaseActorPayload payload, IRecipientFactory recipientFactory, IRepository<Recipient> recipientRepository)
            : base(payload)
        {
            _recipientFactory = recipientFactory;
            _recipientRepository = recipientRepository;

            ReceiveAsync<CreateRecipientCommand>(Handle);
        }

        private async Task Handle(CreateRecipientCommand command)
        {
            await HandleCommand(command, async x =>
            {
                var address = new AddressValueObject(command.City, command.Street, command.Number);

                var recipient = await _recipientFactory.Create(Guid.NewGuid(), command.Metadata.TenantId, command.Name, address);

                await _recipientRepository.Save(recipient);
            });
        }
    }
}