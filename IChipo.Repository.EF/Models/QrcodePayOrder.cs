using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class QrcodePayOrder
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public int? GodId { get; set; }
        public string WeiXinOpenId { get; set; }
        public int? QrcodeId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal DeductionAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? PayDateTime { get; set; }
        public int? Status { get; set; }
        public string Ip { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string OrderNo { get; set; }
        public string Remarks { get; set; }
        public string PayUser { get; set; }
        public string ShopName { get; set; }
        public string BusinessWeiXinOpenId { get; set; }
        public string ZoneNo { get; set; }
        public int? OrderType { get; set; }
        public string TransactionNo { get; set; }
        public string OtherTransactionNo { get; set; }
        public string PayBankType { get; set; }
        public bool IsComment { get; set; }
        public int BranchShopId { get; set; }
        public string Appid { get; set; }
        public int MchId { get; set; }
        public int FeeType { get; set; }
        public decimal Fee { get; set; }
        public decimal FeeRate { get; set; }
        public int DiscountType { get; set; }
        public int CouponId { get; set; }
        public decimal CouponValue { get; set; }
        public decimal FullDiscountUseValue { get; set; }
        public decimal FullDiscountValue { get; set; }
        public int? SettlementMode { get; set; }
        public int PrintCount { get; set; }
        public int TaskId { get; set; }
        public int TaskReceiveId { get; set; }
        public int? AddTaskSaleCount { get; set; }
        public int DeductionType { get; set; }
        public int DeductionReferrerId { get; set; }
        public decimal DeductionReferrerScore { get; set; }
        public int OrderSource { get; set; }
        public string DeviceSn { get; set; }
    }
}
