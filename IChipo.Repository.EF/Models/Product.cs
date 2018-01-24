using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string Name { get; set; }
        public int? ProductStatus { get; set; }
        public decimal? ListPrice { get; set; }
        public int? ClickQuantity { get; set; }
        public int? ShopId { get; set; }
        public string Lable { get; set; }
        public int? Sort { get; set; }
        public bool? IsEnableDistribution { get; set; }
        public string Unit { get; set; }
        public bool? IsRecommend { get; set; }
        public bool? IsNew { get; set; }
        public bool? IsSelling { get; set; }
        public bool? IsPromotions { get; set; }
        public bool? IsFreeShipping { get; set; }
        public bool? IsCrossBorder { get; set; }
        public bool? IsDiscount { get; set; }
        public string Remark { get; set; }
        public bool? IsReal { get; set; }
        public int? TotalSales { get; set; }
        public int? TotalStock { get; set; }
        public string ProductCode { get; set; }
        public int? VirtualSales { get; set; }
        public string ListPicture { get; set; }
        public int? ProductTypeId { get; set; }
        public decimal? DistributionRate { get; set; }
        public decimal? Shipment { get; set; }
        public int? ProductSkuId { get; set; }
        public int? Pid { get; set; }
        public bool? IsShow { get; set; }
    }
}
