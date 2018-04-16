using System;

namespace Core.Message
{
    public class Metadata
    {
        public string Culture { get; private set; }
        public Guid? TenantId { get; private set; }

        public Metadata(string culture, Guid? tenantId)
        {
            Culture = culture;
            TenantId = tenantId;
        }
    }
}