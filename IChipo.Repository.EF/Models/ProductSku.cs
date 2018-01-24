using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ProductSku
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? ProductId { get; set; }
        public int? Stock { get; set; }
        public int? WarningStock { get; set; }
        public int? IsOnShelf { get; set; }
        public decimal? Price { get; set; }
        public string Code { get; set; }
        public int? Weight { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public string SpecificationCode { get; set; }
        public string SpecificationName { get; set; }
    }
}
