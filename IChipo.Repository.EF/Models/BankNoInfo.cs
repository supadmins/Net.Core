using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class BankNoInfo
    {
        public int Id { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string BankNo { get; set; }
        public string BankName { get; set; }
        public string BankId { get; set; }
        public bool? IsAllow { get; set; }
    }
}
