using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class PromotionsRelationProduct
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? PromotionsId { get; set; }
        public int? ProductId { get; set; }
    }
}
