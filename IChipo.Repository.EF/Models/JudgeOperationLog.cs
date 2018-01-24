using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class JudgeOperationLog
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? JudgeId { get; set; }
        public string Remark { get; set; }
        public string OldDataJson { get; set; }
        public string NewDataJson { get; set; }
        public int? CompetenceId { get; set; }
    }
}
