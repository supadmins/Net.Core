using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TerminalStartupPage
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public bool IsPublished { get; set; }
        public string Remark { get; set; }
        public int Sort { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
