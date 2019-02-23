using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Domain.Entities;
using Core.Presentation.Pagination;
using LinqKit;
using Microsoft.EntityFrameworkCore;

namespace Core.Infrastructure.Repositories
{
    public abstract class BaseRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        private readonly DbContext _context;
        private readonly DbSet<TAggregateRoot> _dbSet;
        private readonly ISortExpression<TAggregateRoot> _sortExpression;

        protected BaseRepository(DbContext context, ISortExpression<TAggregateRoot> sortExpression)
        {
            _context = context;
            _sortExpression = sortExpression;
            _dbSet = _context.Set<TAggregateRoot>();
        }

        protected async Task<TAggregateRoot[]> Filter(Expression<Func<TAggregateRoot, bool>> filter)
        {
            filter = PredicateBuilder.New<TAggregateRoot>(x => x.IsDeleted == false).And(filter);

            var query = _dbSet.Where(filter);

            return await query.ToArrayAsync();
        }

        protected async Task<TAggregateRoot> Get(Expression<Func<TAggregateRoot, bool>> filter)
        {
            filter = PredicateBuilder.New<TAggregateRoot>(x => x.IsDeleted == false).And(filter);

            var query = _dbSet.Where(filter);

            return await query.SingleOrDefaultAsync();
        }

        protected async Task<TAggregateRoot[]> GetPagedData(Expression<Func<TAggregateRoot, bool>> filter, int page, int itemsPerPage, string sortBy, SortDirection sortDir)
        {
            page = page > 0 ? page : 1;

            filter = PredicateBuilder.New<TAggregateRoot>(x => x.IsDeleted == false).And(filter);

            var query = _dbSet.Where(filter);

            query = _sortExpression.SortBy(query, sortBy, sortDir);

            query = query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);

            return await query.ToArrayAsync();
        }

        protected async Task<long> GetTotalItemsCount(Expression<Func<TAggregateRoot, bool>> filter)
        {
            filter = PredicateBuilder.New<TAggregateRoot>(x => x.IsDeleted == false).And(filter);

            return await _dbSet.CountAsync(filter);
        }

        public async Task Save(TAggregateRoot aggregate)
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

        public async Task SaveAll(ICollection<TAggregateRoot> aggregates)
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