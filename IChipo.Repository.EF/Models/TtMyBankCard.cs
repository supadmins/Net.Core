using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TtMyBankCard
    {
        public int Id { get; set; }
        public string BankCardNo { get; set; }
        public string BankCardName { get; set; }
        public string BankCode { get; set; }
        public bool? IsDefault { get; set; }
        public int? GodId { get; set; }
        public string AreaCode { get; set; }
        public string Provincial { get; set; }
        public string City { get; set; }
        public string BranchBankName { get; set; }
        public int? BankType { get; set; }
        public string BankNo { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public string Ip { get; set; }
        public string FullName { get; set; }
        public string PayeeBankId { get; set; }
        public string IdcardNo { get; set; }
        public int? BankCardType { get; set; }
        public string Phone { get; set; }
    }
}
