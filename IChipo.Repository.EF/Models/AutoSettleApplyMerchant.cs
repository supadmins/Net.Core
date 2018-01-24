using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AutoSettleApplyMerchant
    {
        public int Id { get; set; }
        public int AutoSettleApplyId { get; set; }
        public int? AppId { get; set; }
        public int? ChannelId { get; set; }
        public string MchId { get; set; }
        public string MchKey { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
