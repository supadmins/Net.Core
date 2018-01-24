using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ReferrerConventionalRateSet
    {
        public int Id { get; set; }
        public decimal MinAmount { get; set; }
        public decimal MaxAomunt { get; set; }
        public decimal Rate { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
