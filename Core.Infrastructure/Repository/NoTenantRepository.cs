using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Domain.Entity;
using Core.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Core.Presentation.Repository;

namespace Core.Infrastructure.Repository
{
    public class NoTenantRepository<TAggregateRoot>
        : BaseRepository<TAggregateRoot>, IRepository<TAggregateRoot>, IReadOnlyRepository<TAggregateRoot>
        where TAggregateRoot : AggregateRoot
    {
        public NoTenantRepository(DbContext context) : base(context)
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