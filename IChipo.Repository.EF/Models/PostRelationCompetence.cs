using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class PostRelationCompetence
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? PostId { get; set; }
        public int CompetenceId { get; set; }
    }
}
