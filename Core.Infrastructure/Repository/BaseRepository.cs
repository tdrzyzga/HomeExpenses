﻿using Core.Domain.Entities;
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

        public virtual async Task SaveAsync(TAggregateRoot aggregate)
        {
            var state = _context.Entry(aggregate).State;
            if (state == EntityState.Detached)
            {
                await _dbSet.AddAsync(aggregate);
            }
            else
            {
                aggregate.ModifyOn(DateTime.UtcNow);
            }

            await _context.SaveChangesAsync();
        }

        public async Task SaveAllAsync(ICollection<TAggregateRoot> aggregates)
        {
            foreach (var aggregateRoot in aggregates)
            {
                var state = _context.Entry(aggregateRoot).State;
                if (state == EntityState.Detached)
                {
                    await _dbSet.AddAsync(aggregateRoot);
                }
                else
                {
                    aggregateRoot.ModifyOn(DateTime.UtcNow);
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
