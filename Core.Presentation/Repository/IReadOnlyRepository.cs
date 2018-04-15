using Core.Domain.Entities;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Presentation.Repository
{
    public interface IReadRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        Task<TAggregateRoot[]> Filter(Expression<Func<TAggregateRoot, bool>> filter, Guid? tenantId = null);
        Task<TAggregateRoot> Get(Guid aggregateId, Guid? tenantId = null);
    }
}