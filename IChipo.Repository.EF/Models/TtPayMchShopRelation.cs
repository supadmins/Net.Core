using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TtPayMchShopRelation
    {
        public int Id { get; set; }
        public int MchType { get; set; }
        public string MchId { get; set; }
        public string MchKey { get; set; }
        public int ShopId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? TtMchId { get; set; }
    }
}
