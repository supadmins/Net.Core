using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class Promotions
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public int? ShopId { get; set; }
        public bool? IsCoupon { get; set; }
        public string Remark { get; set; }
        public bool? IsFreePost { get; set; }
        public bool? IsAll { get; set; }
        public int? ConditionQuantity { get; set; }
        public int? CouponStock { get; set; }
        public int? CouponQuantity { get; set; }
        public decimal? ThresholdAmount { get; set; }
        public decimal? ReduceAmount { get; set; }
        public int? GroupBuyLeastQuantity { get; set; }
        public decimal? GroupBuyPrice { get; set; }
        public decimal? BargainMinPrice { get; set; }
        public int? GiftCouponId { get; set; }
        public decimal? DiscountsRate { get; set; }
        public int? GiftIntegral { get; set; }
        public decimal? GroupBuyTeamLeaderDiscountsRate { get; set; }
        public int? GodGroupId { get; set; }
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public int? PromotionsType { get; set; }
        public bool? IsGroupon { get; set; }
    }
}
