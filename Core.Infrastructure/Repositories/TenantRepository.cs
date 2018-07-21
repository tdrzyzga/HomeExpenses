using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Domain.Entities;
using Core.Domain.Repositories;
using Core.Presentation.Repositories;
using LinqKit;
using Microsoft.EntityFrameworkCore;

namespace Core.Infrastructure.Repositories
{
    public class TenantRepository<TAggregateRoot>
        : BaseRepository<TAggregateRoot>, IRepository<TAggregateRoot>, IReadOnlyRepository<TAggregateRoot>
        where TAggregateRoot : AggregateRoot, IHaveTenant
    {
        public TenantRepository(DbContext context) : base(context)
        {
        }

        public async Task<TAggregateRoot[]> Filter(Expression<Func<TAggregateRoot, bool>> filter, Guid? tenantId = null)
        {
            var newFilter = ApplyTenantFiltering(filter, tenantId);

            return await base.Filter(newFilter);
        }

        public async Task<TAggregateRoot> Get(Guid aggregateId, Guid? tenantId = null)
        {
            var newFilter = ApplyTenantFiltering(x => x.Id == aggregateId, tenantId);

            return await base.Get(newFilter);
        }

        private Expression<Func<TAggregateRoot, bool>> ApplyTenantFiltering(Expression<Func<TAggregateRoot, bool>> baseFilter, Guid? tenantId)
        {
            if (!tenantId.HasValue)
            {
                throw new InvalidOperationException("TenantId has to be provided in tenant repository.");
            }

            var newFilter = PredicateBuilder.New<TAggregateRoot>(x => x.TenantId == tenantId.Value).And(baseFilter);

            return newFilter;
        }
    }
}