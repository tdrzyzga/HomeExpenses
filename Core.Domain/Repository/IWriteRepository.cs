using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain.Entities;

namespace Core.Domain.Repository
{
    public interface IWriteRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        Task SaveAsync(TAggregateRoot aggregate);
        Task SaveAllAsync(ICollection<TAggregateRoot> aggregates);
    }
}