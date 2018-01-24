using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class IndustriesScoreConfig
    {
        public int Id { get; set; }
        public int IndustriesId { get; set; }
        public int? MaxDailySales { get; set; }
        public int? FluctuantScale { get; set; }
        public int TotalRatioByUser { get; set; }
        public int? RatioForPayByUser { get; set; }
        public int? RatioForCommentByUser { get; set; }
        public int? RatioForShareByUser { get; set; }
        public int? RatioForOtherByUser { get; set; }
        public int TotalRatioByShop { get; set; }
        public int? RatioForPayByShop { get; set; }
        public int? RatioForCommentByShop { get; set; }
        public int? RatioForRewardByShop { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
        public int? MaxScoreDay { get; set; }
        public int AvgAmount { get; set; }
    }
}
