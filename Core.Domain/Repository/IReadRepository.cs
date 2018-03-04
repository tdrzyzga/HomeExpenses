using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Repository
{
    public interface IReadRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        Task<ICollection<TAggregateRoot>> Filter(Expression<Func<TAggregateRoot, bool>> filter);
        Task<TAggregateRoot> Get(Guid aggregateId);
    }
}
