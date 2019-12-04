using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Domain.Entities;
using Core.Domain.Repositories;
using Core.Presentation.Pagination;
using Core.Presentation.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Infrastructure.Repositories
{
    public class NoTenantRepository<TAggregateRoot>
        : BaseRepository<TAggregateRoot>, IRepository<TAggregateRoot>, IReadOnlyRepository<TAggregateRoot>
        where TAggregateRoot : AggregateRoot
    {
        public NoTenantRepository(DbContext context, ISortExpression<TAggregateRoot> sortExpression) : base(context, sortExpression)
        {
            if (typeof(IHaveTenant).IsAssignableFrom(typeof(TAggregateRoot)))
            {
                throw new InvalidOperationException("No-tenant repository created for tenant-able entity. Verify your DI registrations.");
            }
        }

        public async Task<TAggregateRoot[]> Filter(Expression<Func<TAggregateRoot, bool>> filter, Guid? tenantId = null)
        {
            CheckTenantId(tenantId);

            return await base.Filter(filter);
        }
        
        public Task<TAggregateRoot[]> GetPagedData(Expression<Func<TAggregateRoot, bool>> filter, int pageIndex, int itemsPerPage, string sortBy, SortDirection sortDir, Guid? tenantId = null)
        {
            CheckTenantId(tenantId);

            return base.GetPagedData(filter, pageIndex, itemsPerPage, sortBy, sortDir);
        }

        public async Task<long> GetTotalItemsCount(Expression<Func<TAggregateRoot, bool>> filter, Guid? tenantId = null)
        {
            CheckTenantId(tenantId);

            return await base.GetTotalItemsCount(filter);
        }

        public async Task<TAggregateRoot> Get(Guid aggregateId, Guid? tenantId)
        {
            CheckTenantId(tenantId);

            return await base.Get(x => x.Id == aggregateId);
        }

        private void CheckTenantId(Guid? tenantId)
        {
            if (tenantId.HasValue)
            {
                throw new InvalidOperationException("Cannot filtering by tenant in no-tenant repository.");
            }
        }
    }
}