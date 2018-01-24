using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TerminalManage
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int ShopId { get; set; }
        public string No { get; set; }
        public int Type { get; set; }
        public string MerchantNo { get; set; }
        public int? State { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string Sdppuk { get; set; }
        public bool? IsAutoNotify { get; set; }
        public int ChannelNo { get; set; }
        public int SettlementMode { get; set; }
    }
}
