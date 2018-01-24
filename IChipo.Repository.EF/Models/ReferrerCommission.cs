using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ReferrerCommission
    {
        public int Id { get; set; }
        public int? ReferrerUserId { get; set; }
        public int? CommissionId { get; set; }
        public int? CommissionType { get; set; }
        public int? RelationId { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? CommissionAmount { get; set; }
        public decimal? Rate { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
