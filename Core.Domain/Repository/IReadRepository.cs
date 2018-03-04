using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Domain.Entities;

namespace Core.Domain.Repository
{
    public interface IReadRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        Task<ICollection<TAggregateRoot>> Filter(Expression<Func<TAggregateRoot, bool>> filter);
        Task<TAggregateRoot> Get(Guid aggregateId);
    }
}