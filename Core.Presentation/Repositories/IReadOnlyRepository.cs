using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Domain.Entities;
using Core.Presentation.Pagination;

namespace Core.Presentation.Repositories
{
    public interface IReadOnlyRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        Task<TAggregateRoot[]> Filter(Expression<Func<TAggregateRoot, bool>> filter, Guid? tenantId = null);
        Task<TAggregateRoot[]> GetPagedData(Expression<Func<TAggregateRoot, bool>> filter, int page, int itemsPerPage, string sortBy, SortDirection sortDir, Guid? tenantId = null);
        Task<long> GetTotalItemsCount(Expression<Func<TAggregateRoot, bool>> filter, Guid? tenantId = null);
        Task<TAggregateRoot> Get(Guid aggregateId, Guid? tenantId = null);
    }
}