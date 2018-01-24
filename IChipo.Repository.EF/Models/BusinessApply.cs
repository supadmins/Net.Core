using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class BusinessApply
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public int? States { get; set; }
        public int? Type { get; set; }
        public int? SettlementType { get; set; }
        public string TerminalNo { get; set; }
        public string Remarks { get; set; }
        public bool? IsApply { get; set; }
        public DateTime? ApplyTime { get; set; }
        public DateTime? OperateTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
