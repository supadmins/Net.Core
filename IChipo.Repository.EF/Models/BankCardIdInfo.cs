using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class BankCardIdInfo
    {
        public int Id { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string BankCardId { get; set; }
        public string BankName { get; set; }
    }
}
