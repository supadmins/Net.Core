using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class GodGroup
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string Name { get; set; }
        public int? ShopId { get; set; }
        public bool? IsDefault { get; set; }
    }
}
