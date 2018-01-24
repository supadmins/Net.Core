using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ReferrerBankCard
    {
        public int Id { get; set; }
        public int? ReferrerUserId { get; set; }
        public string CardholderName { get; set; }
        public string CardNo { get; set; }
        public string BankName { get; set; }
        public string BankCode { get; set; }
        public int CardType { get; set; }
        public string CardSerialNumber { get; set; }
        public string AreaId { get; set; }
        public string PhoneNumber { get; set; }
        public string IdcardNumber { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
