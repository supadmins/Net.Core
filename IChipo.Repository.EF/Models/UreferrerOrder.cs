using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class UreferrerOrder
    {
        public int Id { get; set; }
        public int ReferrerId { get; set; }
        public decimal Amount { get; set; }
        public int ShopId { get; set; }
        public DateTime? PayDateTime { get; set; }
        public int FeeType { get; set; }
        public decimal Fee { get; set; }
        public decimal FeeRate { get; set; }
        public string DeviceSn { get; set; }
        public int OrderSource { get; set; }
        public int? SettlementMode { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
