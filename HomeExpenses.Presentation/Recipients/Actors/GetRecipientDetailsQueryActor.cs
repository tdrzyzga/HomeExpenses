using System.Threading.Tasks;
using Core.Akka.ActorAutostart;
using Core.Presentation.Actors;
using Core.Presentation.Repositories;
using HomeExpenses.Domain.Recipients.Model;
using HomeExpenses.Message.Recipients.Queries;

namespace HomeExpenses.Presentation.Recipients.Actors
{
    [AutostartActor("GetRecipientDetailsQueryActor")]
    public class GetRecipientDetailsQueryActor : BaseActor, IQueryActor<GetRecipientDetailsQuery>
    {
        private readonly IReadOnlyRepository<Recipient> _recipientRepository;

        public GetRecipientDetailsQueryActor(IBaseActorPayload payload, IReadOnlyRepository<Recipient> recipientRepository)
            : base(payload)
        {
            _recipientRepository = recipientRepository;
            ReceiveAsync<GetRecipientDetailsQuery>(Handle);
        }

        private async Task Handle(GetRecipientDetailsQuery query)
        {
            await HandleQuery(query, async x =>
            {
                var recipient = await _recipientRepository.Get(query.Id, query.Metadata.TenantId);

                if (recipient == null)
                {
                    return null;
                }

                return new GetRecipientDetailsResult(recipient.Id, recipient.Name, recipient.Address.City, recipient.Address.Street, recipient.Address.Number);
            });
        }
    }
}