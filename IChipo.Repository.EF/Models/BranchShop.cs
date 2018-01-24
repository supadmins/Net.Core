using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class BranchShop
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public string BranchShopName { get; set; }
        public string Address { get; set; }
        public string AddressDeatil { get; set; }
        public double? PointLongitude { get; set; }
        public double? Latitude { get; set; }
        public int AreaId { get; set; }
        public string TelePhone { get; set; }
        public string Logo { get; set; }
        public string Doorway { get; set; }
        public string BusinessLicense { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
        public int MchId { get; set; }
        public string ServicePhone { get; set; }
        public DateTime? StartWorkTime { get; set; }
        public DateTime? EndWorkTime { get; set; }
        public bool? IsShow { get; set; }
    }
}
