using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class PlatformBankCard
    {
        public int Id { get; set; }
        public string RealName { get; set; }
        public string BankCardNumber { get; set; }
        public string BankName { get; set; }
        public string Picture { get; set; }
        public decimal? LimitAmount { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
