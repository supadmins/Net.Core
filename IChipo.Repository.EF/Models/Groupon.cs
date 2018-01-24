using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class Groupon
    {
        public int Id { get; set; }
        public int? Sku { get; set; }
        public decimal? GrouponPrice { get; set; }
        public int? Number { get; set; }
        public int? GrouponShares { get; set; }
        public DateTime? BeginTime { get; set; }
        public int? NeedTime { get; set; }
        public int? Status { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool? IsPick { get; set; }
        public string Tip { get; set; }
        public string Remarks { get; set; }
        public int? ShopId { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? SalesCount { get; set; }
        public bool? IsShow { get; set; }
        public int? Sort { get; set; }
        public bool? IsTop { get; set; }
        public bool? IsHot { get; set; }
        public int? Category { get; set; }
    }
}
