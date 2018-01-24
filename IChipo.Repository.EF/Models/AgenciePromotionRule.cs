using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AgenciePromotionRule
    {
        public int Id { get; set; }
        public int PromotionId { get; set; }
        public int Type { get; set; }
        public decimal? FullAmount { get; set; }
        public decimal? BackAmount { get; set; }
        public int? BackScore { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
