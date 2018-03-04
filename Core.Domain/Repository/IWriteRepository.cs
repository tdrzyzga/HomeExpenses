using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Repository
{ 
    public interface IWriteRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        Task SaveAsync(TAggregateRoot aggregate);
        Task SaveAllAsync(ICollection<TAggregateRoot> aggregates);
    }
}
