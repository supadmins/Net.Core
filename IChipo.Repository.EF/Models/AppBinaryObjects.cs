using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AppBinaryObjects
    {
        public Guid Id { get; set; }
        public int? TenantId { get; set; }
        public byte[] Bytes { get; set; }
    }
}
