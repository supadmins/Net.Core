using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class Pages
    {
        public int Id { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? PageSectionId { get; set; }
        public int? Sort { get; set; }
    }
}
