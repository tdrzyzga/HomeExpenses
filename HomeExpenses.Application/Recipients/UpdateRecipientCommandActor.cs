using System.Threading.Tasks;
using Core.Akka.ActorAutostart;
using Core.Application.Actors;
using Core.Domain.Repositories;
using Core.Domain.ValueObjects;
using HomeExpenses.Domain.Recipients.Model;
using HomeExpenses.Message.Recipients.Commands;

namespace HomeExpenses.Application.Recipients
{
    [AutostartActor("UpdateRecipientCommandActor")]
    public class UpdateRecipientCommandActor : BaseActor, ICommandActor<UpdateRecipientCommand>
    {
        private readonly IRepository<Recipient> _recipientRepository;

        public UpdateRecipientCommandActor(IBaseActorPayload payload, IRepository<Recipient> recipientRepository)
            : base(payload)
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