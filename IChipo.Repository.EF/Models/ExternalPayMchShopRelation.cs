using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ExternalPayMchShopRelation
    {
        public int Id { get; set; }
        public int RecordId { get; set; }
        public int MerchantId { get; set; }
        public int ShopId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
