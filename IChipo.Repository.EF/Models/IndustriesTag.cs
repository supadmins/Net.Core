using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class IndustriesTag
    {
        public int Id { get; set; }
        public int IndustriesId { get; set; }
        public int TagId { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
