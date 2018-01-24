using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ProductEvaluation
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? GodId { get; set; }
        public string Contents { get; set; }
        public int? ShopId { get; set; }
    }
}
