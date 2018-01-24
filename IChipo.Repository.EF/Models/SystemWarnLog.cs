using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class SystemWarnLog
    {
        public int Id { get; set; }
        public int? Level { get; set; }
        public int? LevelB { get; set; }
        public string Source { get; set; }
        public string Module { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string TriggerValue { get; set; }
        public string RelationValue { get; set; }
        public string Solution { get; set; }
        public bool? IsHandle { get; set; }
        public bool? IsClosed { get; set; }
        public DateTime? NextExcuteTime { get; set; }
        public string NextRelationValue { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
