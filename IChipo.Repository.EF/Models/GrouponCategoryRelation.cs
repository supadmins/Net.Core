using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class GrouponCategoryRelation
    {
        public int Id { get; set; }
        public int? GrouponId { get; set; }
        public int? GrouopnCategoryId { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
