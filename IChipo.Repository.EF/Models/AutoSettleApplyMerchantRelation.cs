using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AutoSettleApplyMerchantRelation
    {
        public int Id { get; set; }
        public int AutoSettleApplyId { get; set; }
        public int MerchantShopRelationId { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
