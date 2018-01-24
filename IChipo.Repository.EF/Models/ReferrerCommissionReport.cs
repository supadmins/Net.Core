using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ReferrerCommissionReport
    {
        public int Id { get; set; }
        public int? ReferrerUserId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
