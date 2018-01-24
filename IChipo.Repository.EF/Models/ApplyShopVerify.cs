using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ApplyShopVerify
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TelePhone { get; set; }
        public string ShopNotece { get; set; }
        public string Body { get; set; }
        public string Logo { get; set; }
        public int? ShopId { get; set; }
        public double? DeliveryArea { get; set; }
        public string Subname { get; set; }
    }
}
