using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AgenciePromotion
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? IsEnabled { get; set; }
        public string Description { get; set; }
        public int? Sort { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
