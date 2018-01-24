using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class QrCodePayOrderStatistics
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int? LastDayTradeCount { get; set; }
        public decimal? LastDayTradeAmount { get; set; }
        public int? LastMonthTradeCount { get; set; }
        public decimal? LastMonthTradeAmount { get; set; }
        public string Remark { get; set; }
        public DateTime StatisticsDate { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
