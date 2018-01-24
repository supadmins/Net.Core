using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? ProductSkuid { get; set; }
        public int? OrderFormId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string Name { get; set; }
        public string SpecificationName { get; set; }
        public int? ProductType { get; set; }
        public int? PromotionId { get; set; }
        public string PromotionRemark { get; set; }
        public decimal? OriginalPrice { get; set; }
        public bool? IsDistribution { get; set; }
        public int? DistributorGodId { get; set; }
        public decimal? DistributorReward { get; set; }
        public int? FatherDistributorGodId { get; set; }
        public decimal? FatherDistributorReward { get; set; }
        public int? GrandfatherDistributorGodId { get; set; }
        public decimal? GrandfatherDistributorReward { get; set; }
        public string ProductListPicture { get; set; }
    }
}
