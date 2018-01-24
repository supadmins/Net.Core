using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class UserScoreLog
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public bool? Status { get; set; }
        public string PlatformNo { get; set; }
        public int? OrderType { get; set; }
        public int? Score { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Remarks { get; set; }
        public int? GodId { get; set; }
    }
}
