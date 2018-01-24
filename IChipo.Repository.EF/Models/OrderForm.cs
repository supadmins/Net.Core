using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class OrderForm
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string Address { get; set; }
        public decimal? PayAmount { get; set; }
        public int? ShopId { get; set; }
        public int? GodId { get; set; }
        public int? DeliveryType { get; set; }
        public string OrderFormNumber { get; set; }
        public string GodRemark { get; set; }
        public int? OrderFormStatus { get; set; }
        public decimal? Amount { get; set; }
        public int? TotalQuantity { get; set; }
        public decimal? DeliveryFee { get; set; }
        public bool? IsShopFreeDeliveryFee { get; set; }
        public string CustomerServiceRemark { get; set; }
        public DateTime? PayTime { get; set; }
        public int? TradingSources { get; set; }
        public DateTime? ForecastPostTime { get; set; }
        public string DeliveryNumber { get; set; }
        public int? ShipAreaId { get; set; }
        public int? ReceiptAreaId { get; set; }
        public int? ActivistStatus { get; set; }
        public int? PaymentType { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhoneNumber { get; set; }
        public string GodComment { get; set; }
        public int? GodCommentLevel { get; set; }
        public string ShopName { get; set; }
        public decimal? ProductTotalAmount { get; set; }
        public int? PayLastMinute { get; set; }
        public DateTime? PayEndDateTime { get; set; }
        public bool? ReceiverSex { get; set; }
        public decimal? DiscountedAmount { get; set; }
        public decimal? PayBalanceAmount { get; set; }
        public string DeliveryCompany { get; set; }
        public decimal? OnlinePaymentAmount { get; set; }
        public string ShopReplyComment { get; set; }
        public DateTime? GodCommentDateTime { get; set; }
        public DateTime? ShopReplyCommentDateTime { get; set; }
        public int? ShopGodId { get; set; }
        public DateTime? ReceiptDateTime { get; set; }
        public DateTime? ShippedDateTime { get; set; }
        public DateTime? ApplyReturnDateTime { get; set; }
        public int? Mode { get; set; }
        public DateTime? SubmitDateTime { get; set; }
        public decimal? CashOnDeliveryAmount { get; set; }
        public string ReturnReasonToShop { get; set; }
        public string ReturnReasonToSite { get; set; }
        public DateTime? ApplyPlatformArbitrationDateTime { get; set; }
        public decimal? Shipment { get; set; }
        public decimal? ActualPayAmount { get; set; }
        public int? OrderType { get; set; }
        public int? GrouponId { get; set; }
        public int? GrouponDetailId { get; set; }
        public string IpAddress { get; set; }
    }
}
