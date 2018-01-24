using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TtShop
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TelePhone { get; set; }
        public string WorkDateTime { get; set; }
        public int? AreaId { get; set; }
        public int? ShopStatus { get; set; }
        public int? Sort { get; set; }
        public int? Mode { get; set; }
        public string ShopNotece { get; set; }
        public string Body { get; set; }
        public double? PointLongitude { get; set; }
        public double? Latitude { get; set; }
        public int? DeliveryMinute { get; set; }
        public decimal? DeliveryStartPrice { get; set; }
        public decimal? Shipment { get; set; }
        public string Tag { get; set; }
        public int? ShopTemplateId { get; set; }
        public decimal? TotalOrderAmount { get; set; }
        public string Logo { get; set; }
        public int? ProductTypeId { get; set; }
        public decimal? DistributionRate { get; set; }
        public int? ShipmentType { get; set; }
        public bool? IsAllowDeliveryPay { get; set; }
        public int? GodId { get; set; }
        public int? QualificationStatus { get; set; }
        public int? VerifyStatus { get; set; }
        public double? DeliveryArea { get; set; }
        public decimal? CommentLevel { get; set; }
        public int? CommentTotal { get; set; }
        public bool? IsApplyShopQuanlification { get; set; }
        public bool? IsApplyShopVerify { get; set; }
        public string BusinessLicense { get; set; }
        public string IdcardPositive { get; set; }
        public string IdcardNegative { get; set; }
        public string TaxRegistration { get; set; }
        public int? ShopType { get; set; }
        public int? Pid { get; set; }
        public int? DifferenceComment { get; set; }
        public int? MiddleComment { get; set; }
        public int? GoodComment { get; set; }
        public bool? IsBind { get; set; }
        public int? QrcodeId { get; set; }
        public bool? IsShow { get; set; }
        public int IndustriesId { get; set; }
        public string Subname { get; set; }
        public string Doorway { get; set; }
        public string BusinessCertificate { get; set; }
        public string IdNumber { get; set; }
        public string IdCardInHand { get; set; }
        public string ShopkeeperName { get; set; }
        public int? MaxDailySales { get; set; }
        public int? AvgAmount { get; set; }
        public int SalesmanId { get; set; }
        public string RecommendCode { get; set; }
        public int? AgenciesId { get; set; }
        public decimal? CashInRateT0 { get; set; }
        public decimal? CashInRateT1 { get; set; }
        public bool? IsSalesmanCheck { get; set; }
        public DateTime? UpdateNameTime { get; set; }
        public int BranchCount { get; set; }
        public string Appid { get; set; }
        public int? BindMchLevel { get; set; }
        public int? BindMchRelationId { get; set; }
        public string SecurityPwd { get; set; }
        public int? ReferrerUserId { get; set; }
        public int? ReferrerRateType { get; set; }
        public decimal? ReferrerRate { get; set; }
        public string ShortName { get; set; }
        public int? QuickAuthentication { get; set; }
        public decimal CashInRateT11 { get; set; }
        public decimal CashInCapRateD0 { get; set; }
        public decimal CashInCapRateD1 { get; set; }
        public decimal CashInCapRateT1 { get; set; }
        public decimal CashInCapAmount { get; set; }
        public decimal ReferrerRateD1 { get; set; }
        public decimal ReferrerRateT1 { get; set; }
        public decimal ReferrerCapRateD0 { get; set; }
        public decimal ReferrerCapRateD1 { get; set; }
        public decimal ReferrerCapRateT1 { get; set; }
        public decimal ReferrerCapAmount { get; set; }
    }
}
