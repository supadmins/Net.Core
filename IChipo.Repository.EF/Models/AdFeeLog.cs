using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AdFeeLog
    {
        public int Id { get; set; }
        public int? AdvertisersId { get; set; }
        public string AdvertisersName { get; set; }
        public decimal? Amount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? FeeType { get; set; }
        public int? AdType { get; set; }
        public int? Flow { get; set; }
        public int? DiscountFlow { get; set; }
        public int? TotalFlow { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
