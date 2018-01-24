using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ProductSkupriceLog
    {
        public int Id { get; set; }
        public int? ProductSkuid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? DistributionRate { get; set; }
    }
}
