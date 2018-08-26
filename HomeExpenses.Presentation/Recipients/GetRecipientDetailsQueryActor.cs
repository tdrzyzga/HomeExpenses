using System.Threading.Tasks;
using Core.Akka.ActorAutostart;
using Core.Presentation.Actors;
using Core.Presentation.Repositories;
using HomeExpenses.Domain.Recipients.Model;
using HomeExpenses.Message.Recipients.Queries;
using Microsoft.Extensions.Logging;

namespace HomeExpenses.Presentation.Recipients
{
    [AutostartActor("GetRecipientDetailsQueryActor")]
    public class GetRecipientDetailsQueryActor : BaseActor
    {
        private readonly IReadOnlyRepository<Recipient> _recipientRepository;

        public GetRecipientDetailsQueryActor(ILogger<GetRecipientDetailsQueryActor> logger, IReadOnlyRepository<Recipient> recipientRepository)
            : base(logger)
        {
            _recipientRepository = recipientRepository;
            ReceiveAsync<GetRecipientDetailsQuery>(Handle);
        }

        private async Task Handle(GetRecipientDetailsQuery query)
        {
            await HandleQuery(query, async x =>
            {
                var recipient = await _recipientRepository.Get(query.Id, query.Metadata.TenantId);

                return new GetRecipientDetailsResult(recipient.Id, recipient.Name, recipient.Address.City, recipient.Address.Street, recipient.Address.Number);
            });
        }
    }
}