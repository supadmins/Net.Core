using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class JudgeRelationPost
    {
        public int Id { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? JudgeId { get; set; }
        public int? PostId { get; set; }
    }
}
