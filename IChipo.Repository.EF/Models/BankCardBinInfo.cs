using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class BankCardBinInfo
    {
        public int Id { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string CardBin { get; set; }
        public int CardLength { get; set; }
        public string CardType { get; set; }
        public string CardName { get; set; }
        public string BankTitle { get; set; }
        public string BankNo { get; set; }
        public string BankName { get; set; }
        public string FiltMode { get; set; }
    }
}
