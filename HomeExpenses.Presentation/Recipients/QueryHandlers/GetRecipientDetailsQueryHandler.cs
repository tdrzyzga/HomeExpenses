using Core.Presentation.Handlers;
using Core.Presentation.Repositories;
using HomeExpenses.Domain.Recipients.Model;
using HomeExpenses.Message.Recipients.Queries;
using System.Threading.Tasks;

namespace HomeExpenses.Presentation.Recipients.QueryHandlers
{
    public class GetRecipientDetailsQueryHandler : IQueryHandler<GetRecipientDetailsQuery, GetRecipientDetailsQueryResult>
    {
        private readonly IReadOnlyRepository<Recipient> _recipientRepository;

        public GetRecipientDetailsQueryHandler(IReadOnlyRepository<Recipient> recipientRepository)
        {
            _recipientRepository = recipientRepository;
        }

        public async Task<GetRecipientDetailsQueryResult> Handle(GetRecipientDetailsQuery query)
        {
            var recipient = await _recipientRepository.Get(query.Id, query.Metadata.TenantId);

            if (recipient == null)
            {
                return null;
            }

            return new GetRecipientDetailsQueryResult(recipient.Id, recipient.Name, recipient.Address.City, recipient.Address.Street, recipient.Address.Number);
        }
    }
}