using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Domain.Entities;

namespace Core.Presentation.Repositories
{
    public interface IReadOnlyRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        Task<TAggregateRoot[]> Filter(Expression<Func<TAggregateRoot, bool>> filter, Guid? tenantId = null);
        Task<TAggregateRoot> Get(Guid aggregateId, Guid? tenantId = null);
    }
}