using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class Community
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string IsValid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
