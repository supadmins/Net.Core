using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class UserScoreWaterLog
    {
        public int Id { get; set; }
        public int GodId { get; set; }
        public int Score { get; set; }
        public int TotalScore { get; set; }
        public string SourceNo { get; set; }
        public int Type { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
        public string GodOpenId { get; set; }
        public int BranchShopId { get; set; }
    }
}
