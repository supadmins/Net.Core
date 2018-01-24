using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class UserScore
    {
        public int Id { get; set; }
        public int? TotalScore { get; set; }
        public int? GodId { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string CreateUser { get; set; }
    }
}
