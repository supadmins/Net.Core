using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ShopScoreWaterLog
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int Score { get; set; }
        public int TotalScore { get; set; }
        public string SourceNo { get; set; }
        public int Type { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
        public int ShopGodId { get; set; }
        public int BranchShopId { get; set; }
        public bool? IsIn { get; set; }
        public string Remark { get; set; }
    }
}
