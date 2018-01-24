using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class CapitalAccount
    {
        public int Id { get; set; }
        public string SecurityPwd { get; set; }
        public int? GodId { get; set; }
        public string FullName { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Phone { get; set; }
        public int? ShopId { get; set; }
    }
}
