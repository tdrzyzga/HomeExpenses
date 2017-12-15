using Core.Domain.Entities;
using Core.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.Repository
{
    public abstract class BaseRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        private DbContext _context;
        private DbSet<TAggregateRoot> _dbSet;

        public BaseRepository(DbContext context)
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
            var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
        }

        public virtual void Remove(TAggregateRoot aggregate)
        {
            _dbSet.Remove(aggregate);
        }

        public virtual IQueryable<TAggregateRoot> Query()
        {
            return _dbSet.AsQueryable();
        }

        public virtual IQueryable<TAggregateRoot> ReadOnlyQuery()
        {
            return _dbSet.AsNoTracking();
        }

        public virtual async Task<TAggregateRoot> FindByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
