using Core.Domain.Entities;
using Core.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Infrastructure.Database;
using LinqKit;

namespace Core.Infrastructure.Repository
{
    public abstract class BaseRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        private DbContext _context;
        private readonly DbSet<TAggregateRoot> _dbSet;

        protected BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TAggregateRoot>();
        }

        public virtual async Task AddAsync(TAggregateRoot aggregate)
        {
            await _dbSet.AddAsync(aggregate);
        }


        public virtual void Update(TAggregateRoot aggregate)
        {
            _dbSet.Update(aggregate);
        }

        public virtual async Task RemoveAsync(Guid id)
        {
            var query = _dbSet.IncludeAll().Where(x => x.Id == id && x.IsDeleted == false);

            var aggregateRoot = await query.SingleOrDefaultAsync();
            _dbSet.Remove(aggregateRoot);
        }

        public virtual void Remove(TAggregateRoot aggregate)
        {
            _dbSet.Remove(aggregate);
        }

        public virtual async Task<ICollection<TAggregateRoot>> Filter(Expression<Func<TAggregateRoot, bool>> filter)
        {
            filter = PredicateBuilder.New<TAggregateRoot>(x => x.IsDeleted == false).And(filter);

            var query = _dbSet.IncludeAll().Where(filter);

            return await query.ToArrayAsync();
        }

        public virtual async Task<TAggregateRoot> Get(Guid aggregateId)
        {
            var query = _dbSet.IncludeAll().Where(x => x.Id == aggregateId);

            return await query.SingleOrDefaultAsync();
        }

        public virtual async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
