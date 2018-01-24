using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class GodDistributionShop
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? GodId { get; set; }
        public int? ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopNotece { get; set; }
        public string ShopLogo { get; set; }
        public int? ShopTemplateId { get; set; }
    }
}
