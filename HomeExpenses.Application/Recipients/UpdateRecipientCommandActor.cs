using System.Threading.Tasks;
using Core.Akka.ActorAutostart;
using Core.Application.Actors;
using Core.Domain.Repositories;
using Core.Domain.ValueObjects;
using HomeExpenses.Domain.Recipients.Model;
using HomeExpenses.Message.Recipients.Commands;
using Microsoft.Extensions.Logging;

namespace HomeExpenses.Application.Recipients
{
    [AutostartActor("UpdateRecipientCommandActor")]
    public class UpdateRecipientCommandActor : BaseActor
    {
        private readonly IRepository<Recipient> _recipientRepository;

        public UpdateRecipientCommandActor(ILogger<UpdateRecipientCommandActor> logger, IRepository<Recipient> recipientRepository)
            : base(logger)
        {
            _recipientRepository = recipientRepository;

            ReceiveAsync<UpdateRecipientCommand>(Handle);
        }

        private async Task Handle(UpdateRecipientCommand command)
        {
            await HandleCommand(command, async x =>
            {
                var recipient = await _recipientRepository.Get(command.Id, command.Metadata.TenantId);

                var address = new AddressValueObject(command.City, command.Street, command.Number);

                await recipient.ChangeName(command.Name);
                await recipient.ChangeAddress(address);

                await _recipientRepository.Save(recipient);
            });
        }
    }
}