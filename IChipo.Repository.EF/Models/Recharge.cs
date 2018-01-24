using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class Recharge
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public decimal? Amount { get; set; }
        public int? GodId { get; set; }
        public bool? IsAudit { get; set; }
        public string RechargeNumber { get; set; }
        public string Remark { get; set; }
        public decimal? RechargeFee { get; set; }
        public decimal? ActualRechargeFee { get; set; }
        public int? RechargeMode { get; set; }
    }
}
