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
        Task AddAsync(TAggregateRoot aggregate);
        void Update(TAggregateRoot aggregate);
        Task RemoveAsync(Guid id);
        void Remove(TAggregateRoot aggregate);
        Task SaveChangesAsync();
    }
}
