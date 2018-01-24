using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class RuiFuAreaInfo
    {
        public int Id { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public int? AreaLevel { get; set; }
        public string ParentCode { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
