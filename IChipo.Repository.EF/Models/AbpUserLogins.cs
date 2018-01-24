using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AbpUserLogins
    {
        public long Id { get; set; }
        public int? TenantId { get; set; }
        public long UserId { get; set; }
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }

        public AbpUsers User { get; set; }
    }
}
