using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ReferrerAccount
    {
        public int Id { get; set; }
        public int? ReferrerUserId { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? WithdrawalAmount { get; set; }
        public decimal? FundBalance { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
