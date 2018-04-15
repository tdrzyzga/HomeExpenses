using System;

namespace Core.Domain.Entities
{
    public interface IHaveTenant
    {
        Guid? TenantId { get; }
    }
}