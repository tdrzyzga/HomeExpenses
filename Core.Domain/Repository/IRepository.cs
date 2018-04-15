using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Domain.Entities;

namespace Core.Domain.Repository
{
    public interface IRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        Task<TAggregateRoot[]> Filter(Expression<Func<TAggregateRoot, bool>> filter, Guid? tenantId = null);
        Task<TAggregateRoot> Get(Guid aggregateId, Guid? tenantId = null);
        Task SaveAsync(TAggregateRoot aggregate);
        Task SaveAllAsync(ICollection<TAggregateRoot> aggregates);
    }
}