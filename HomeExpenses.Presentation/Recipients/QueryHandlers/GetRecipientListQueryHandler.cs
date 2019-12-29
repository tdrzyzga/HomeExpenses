using Core.Presentation.Handlers;
using Core.Presentation.Pagination;
using Core.Presentation.Repositories;
using HomeExpenses.Domain.Recipients.Model;
using HomeExpenses.Message.Recipients.Queries;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace HomeExpenses.Presentation.Recipients.QueryHandlers
{
    public class GetRecipientListQueryHandler : IQueryHandler<GetRecipientListQuery, GetRecipientListResult>
    {
        private readonly IReadOnlyRepository<Recipient> _recipientRepository;

        public GetRecipientListQueryHandler(IReadOnlyRepository<Recipient> recipientRepository)
        {
            _recipientRepository = recipientRepository;
        }

        public async Task<GetRecipientListResult> Handle(GetRecipientListQuery query)
        {
            var recipients = _recipientRepository.GetPagedData(r => true,
                                                                          query.PageIndex,
                                                                          query.ItemsPerPage,
                                                                          query.SortBy,
                                                                          query.SortDir.ToSortDirection(),
                                                                          query.Metadata.TenantId);

            var totalItems = _recipientRepository.GetTotalItemsCount(r => true, query.Metadata.TenantId);

            await Task.WhenAll(recipients, totalItems);

            var recipientDtos = recipients.Result.Select(r => new GetRecipientListResult.RecipientDto(r.Id, r.Name, r.Address.City, r.Address.Street, r.Address.Number));

            return new GetRecipientListResult(recipientDtos.ToImmutableArray(), (int)totalItems.Result);
        }
    }
}