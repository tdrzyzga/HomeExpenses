//using System.Collections.Immutable;
//using System.Linq;
//using System.Threading.Tasks;
//using Core.Akka.ActorAutostart;
//using Core.Presentation.Actors;
//using Core.Presentation.Pagination;
//using Core.Presentation.Repositories;
//using HomeExpenses.Domain.Recipients.Model;
//using HomeExpenses.Message.Recipients.Queries;

//namespace HomeExpenses.Presentation.Recipients.Actors
//{
//    [AutostartActor("GetRecipientListQueryActor")]
//    public class GetRecipientListQueryActor : BaseActor, IQueryActor<GetRecipientListQuery>
//    {
//        private readonly IReadOnlyRepository<Recipient> _recipientRepository;

//        public GetRecipientListQueryActor(IBaseActorPayload payload, IReadOnlyRepository<Recipient> recipientRepository)
//            : base(payload)
//        {
//            _recipientRepository = recipientRepository;
//            ReceiveAsync<GetRecipientListQuery>(Handle);
//        }

//        private async Task Handle(GetRecipientListQuery query)
//        {
//            await HandleQuery(query, async x =>
//            {
//                var recipients = _recipientRepository.GetPagedData(r => true, 
//                                                                              query.PageIndex, 
//                                                                              query.ItemsPerPage, 
//                                                                              query.SortBy, 
//                                                                              query.SortDir.ToSortDirection(),
//                                                                              query.Metadata.TenantId);

//                var totalItems = _recipientRepository.GetTotalItemsCount(r => true, query.Metadata.TenantId);

//                await Task.WhenAll(recipients, totalItems);

//                var recipientDtos = recipients.Result.Select(r => new GetRecipientListResult.RecipientDto(r.Id, r.Name, r.Address.City, r.Address.Street, r.Address.Number));

//                return new GetRecipientListResult(recipientDtos.ToImmutableArray(), (int) totalItems.Result);
//            });
//        }
//    }
//}