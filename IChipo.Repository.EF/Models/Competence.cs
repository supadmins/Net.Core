using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class Competence
    {
        public int Id { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Controllers { get; set; }
        public string Action { get; set; }
        public int? PagesId { get; set; }
        public string Name { get; set; }
    }
}
