using Core.Domain.Entities;
using Core.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Core.Infrastructure.Repository
{
    public class ReadRepository<TAggregateRoot>
        : BaseRepository<TAggregateRoot>,
          IReadRepository<TAggregateRoot>
        where TAggregateRoot : AggregateRoot
    {
        public ReadRepository(DbContext context) : base(context)
        {
        }
    }
}