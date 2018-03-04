using Core.Domain.Entities;
using Core.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Core.Infrastructure.Repository
{
    public class WriteRepository<TAggregateRoot>
        : BaseRepository<TAggregateRoot>,
          IWriteRepository<TAggregateRoot>
        where TAggregateRoot : AggregateRoot
    {
        public WriteRepository(DbContext context) : base(context)
        {
        }
    }
}