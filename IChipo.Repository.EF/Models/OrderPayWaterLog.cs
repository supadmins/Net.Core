using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class OrderPayWaterLog
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public int? OrderId { get; set; }
        public string PlatformNo { get; set; }
        public string TransactionNo { get; set; }
        public bool? TradingStatus { get; set; }
        public int? OrderType { get; set; }
        public int? PayMent { get; set; }
        public decimal? Amount { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? ShopId { get; set; }
        public string PayUser { get; set; }
        public string Remarks { get; set; }
        public string Appid { get; set; }
    }
}
