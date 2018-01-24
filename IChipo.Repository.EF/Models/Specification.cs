using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class Specification
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string Name { get; set; }
        public int? SpecificationGroupId { get; set; }
        public int? ShopId { get; set; }
        public string ImgUrl { get; set; }
        public int? Sort { get; set; }
    }
}
