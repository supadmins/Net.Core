using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class SpecificationGroup
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string Name { get; set; }
        public int? ProductTypeId { get; set; }
        public bool? IsSearch { get; set; }
        public bool? IsMust { get; set; }
        public int? Sort { get; set; }
    }
}
