using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class Judge
    {
        public int Id { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Aliases { get; set; }
        public string FullName { get; set; }
        public string LoginKey { get; set; }
        public string Salt { get; set; }
    }
}
