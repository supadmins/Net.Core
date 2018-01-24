using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class PagesSection
    {
        public int Id { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public int? Parent { get; set; }
        public int? Sort { get; set; }
        public string Icon { get; set; }
    }
}
