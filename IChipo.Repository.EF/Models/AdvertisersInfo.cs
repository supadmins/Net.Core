using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AdvertisersInfo
    {
        public int Id { get; set; }
        public int? AdvertisersId { get; set; }
        public string AdvertisersName { get; set; }
        public decimal? SurplusAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? Type { get; set; }
        public int? PayFeeCount { get; set; }
        public int? SurplusFlow { get; set; }
        public int? TotalFlow { get; set; }
        public int? PayFlowCount { get; set; }
        public int? TotalUserCount { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
