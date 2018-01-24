using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AgencieLevel
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string LevelName { get; set; }
        public int? NeedScore { get; set; }
        public decimal? NeedAmount { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
