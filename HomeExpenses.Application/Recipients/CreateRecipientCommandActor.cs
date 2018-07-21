using System.Threading.Tasks;
using Core.Akka.ActorAutostart;
using Core.Application.Actors;
using Core.Domain.Repositories;
using Core.Domain.ValueObjects;
using HomeExpenses.Domain.Recipients.Factory;
using HomeExpenses.Domain.Recipients.Model;
using HomeExpenses.Message.Recipients.Commands;
using Microsoft.Extensions.Logging;

namespace HomeExpenses.Application.Recipients
{
    [AutostartActor("CreateRecipientCommandActor")]
    public class CreateRecipientCommandActor : BaseActor
    {
        private readonly IRecipientFactory _recipientFactory;
        private readonly IRepository<Recipient> _recipientRepository;

        public CreateRecipientCommandActor(ILogger<CreateRecipientCommandActor> logger, IRecipientFactory recipientFactory, IRepository<Recipient> recipientRepository)
            : base(logger)
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

                var recipient = await _recipientFactory.Create(command.Id, command.Metadata.TenantId, command.Name, address);

                await _recipientRepository.Save(recipient);
            });
        }
    }
}