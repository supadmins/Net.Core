using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ExternalPayChannel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal? LimitAmount { get; set; }
        public int? HasMchCount { get; set; }
        public bool? IsEnabled { get; set; }
        public int? Sort { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
