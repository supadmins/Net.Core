using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ShopStatistics
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int BranchShopId { get; set; }
        public string ShopName { get; set; }
        public int? LastDayAllGodCount { get; set; }
        public int? LastDayAllOrderCount { get; set; }
        public int? LastDayTrGodCount { get; set; }
        public int? LastWeekTrGodCount { get; set; }
        public int? LastDayNewGodCount { get; set; }
        public int? LastWeekNewGodCount { get; set; }
        public int? LastDayNewOrderCount { get; set; }
        public int? LastWeekNewOrderCount { get; set; }
        public int? ThreeDayPayGodCount { get; set; }
        public int? SevenDayPayGodCount { get; set; }
        public int? SevenDayNoPayGodCount { get; set; }
        public int? ThirtyDayNoPayGodCount { get; set; }
        public int? PayLess100GodCount { get; set; }
        public int? Pay100To1000GodCount { get; set; }
        public int? PayMore1000GodCount { get; set; }
        public int? PayOneTimeGodCount { get; set; }
        public int? PayTwoTimesGodCount { get; set; }
        public int? PayFiveTimesGodCount { get; set; }
        public int? PayMoreTenTimesGodCount { get; set; }
        public DateTime? StatisticsDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
