using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ProductRelationSpecification
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? SpecificationId { get; set; }
        public int? ProductId { get; set; }
    }
}
