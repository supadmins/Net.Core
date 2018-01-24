using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AgencieBaseInfo
    {
        public int Id { get; set; }
        public int? AgencieType { get; set; }
        public string ShortName { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string ContactPhone { get; set; }
        public string Mobile { get; set; }
        public decimal? SettlementRate { get; set; }
        public decimal? SettlementRateT1 { get; set; }
        public int? SettlementCycle { get; set; }
        public decimal? T0sellerSettlementRate { get; set; }
        public decimal? T1sellerSettlementRate { get; set; }
        public int? Inviter { get; set; }
        public string InviterCode { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public int UpdateBy { get; set; }
        public bool IsValid { get; set; }
        public int AgenciesId { get; set; }
        public decimal? QrcodeSalePrice { get; set; }
        public decimal? QrcodeActiveTradeLimit { get; set; }
        public decimal? QrcodeActiveRewards { get; set; }
        public decimal? T0sellerTtSettlementRate { get; set; }
        public decimal? T1sellerTtSettlementRate { get; set; }
        public bool? IsEnabledActiveReward { get; set; }
        public bool? IsEnabledActiveCharge { get; set; }
        public decimal? QrCodeActiveChargeLimit { get; set; }
        public decimal? QrCodeActiveChargeAmount { get; set; }
        public decimal? TtSettlementRate { get; set; }
        public decimal? TtSettlementRateT1 { get; set; }
        public int AgencieLevel { get; set; }
        public int? ReferrerUserId { get; set; }
        public int? ReferrerRateType { get; set; }
        public decimal? ReferrerRate { get; set; }
        public decimal RatePercent { get; set; }
        public decimal SettlementRateT00 { get; set; }
        public decimal SettlementRateT11 { get; set; }
        public decimal T00ellerSettlementRate { get; set; }
        public decimal T11sellerSettlementRate { get; set; }
        public decimal CreditSettlementRateT1 { get; set; }
        public decimal CreditSettlementRateT0 { get; set; }
        public decimal CreditSettlementRateD1 { get; set; }
        public decimal CreditSettlementRateD0 { get; set; }
        public decimal CreditSellerSettlementRateT1 { get; set; }
        public decimal CreditSellerSettlementRateT0 { get; set; }
        public decimal CreditSellerSettlementRateD1 { get; set; }
        public decimal CreditSellerSettlementRateD0 { get; set; }
        public decimal SavingSettlementRateT0 { get; set; }
        public decimal SavingSettlementRateT1 { get; set; }
        public decimal SavingSettlementRateD1 { get; set; }
        public decimal SavingSettlementRateD0 { get; set; }
        public decimal SavingSettlementCapAmount { get; set; }
        public decimal SavingSellerSettlementRateT1 { get; set; }
        public decimal SavingSellerSettlementRateT0 { get; set; }
        public decimal SavingSellerSettlementRateD1 { get; set; }
        public decimal SavingSellerSettlementRateD0 { get; set; }
        public decimal SavingSellerSettlementCapAmount { get; set; }
        public decimal TtSettlementRateT00 { get; set; }
        public decimal TtSettlementRateT11 { get; set; }
        public decimal T00sellerTtSettlementRate { get; set; }
        public decimal T11sellerTtSettlementRate { get; set; }
        public decimal TtCapSettlementRateT0 { get; set; }
        public decimal TtCapSettlementRateT1 { get; set; }
        public decimal TtCapSettlementRateD0 { get; set; }
        public decimal TtCapSettlementRateD1 { get; set; }
        public decimal TtCapSettlementCapAmount { get; set; }
        public decimal TtCapSellerSettlementRateT0 { get; set; }
        public decimal TtCapSellerSettlementRateT1 { get; set; }
        public decimal TtCapSellerSettlementRateD0 { get; set; }
        public decimal TtCapSellerSettlementRateD1 { get; set; }
        public decimal TtCapSellerSettlementCapAmount { get; set; }
        public decimal ReferrerRateD1 { get; set; }
        public decimal ReferrerRateT0 { get; set; }
        public decimal ReferrerRateT1 { get; set; }
        public decimal ReferrerCreditRateD0 { get; set; }
        public decimal ReferrerCreditRateD1 { get; set; }
        public decimal ReferrerCreditRateT0 { get; set; }
        public decimal ReferrerCreditRateT1 { get; set; }
        public decimal ReferrerSavingRateD0 { get; set; }
        public decimal ReferrerSavingRateD1 { get; set; }
        public decimal ReferrerSavingRateT0 { get; set; }
        public decimal ReferrerSavingRateT1 { get; set; }
        public decimal ReferrerSavingCapAmount { get; set; }
    }
}
