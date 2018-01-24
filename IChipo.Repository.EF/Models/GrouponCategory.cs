using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class GrouponCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string LinkUrl { get; set; }
        public string Remark { get; set; }
        public int? Sort { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
