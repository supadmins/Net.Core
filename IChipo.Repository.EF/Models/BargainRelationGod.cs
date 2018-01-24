using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class BargainRelationGod
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? GodId { get; set; }
        public int? BargainId { get; set; }
        public decimal? OldPrice { get; set; }
        public decimal? NewPrice { get; set; }
        public decimal? BargainPrice { get; set; }
        public bool? IsBuy { get; set; }
    }
}
