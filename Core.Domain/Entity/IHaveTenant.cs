using System;

namespace Core.Domain.Entity
{
    public interface IHaveTenant
    {
        Guid? TenantId { get; }
    }
}