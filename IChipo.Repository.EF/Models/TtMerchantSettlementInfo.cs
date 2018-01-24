using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TtMerchantSettlementInfo
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string IdcardNo { get; set; }
        public string BankCardNo { get; set; }
        public string BankName { get; set; }
        public int? CardType { get; set; }
        public string BankId { get; set; }
        public string BranchBankId { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string CityName { get; set; }
        public string Province { get; set; }
        public string ProvinceName { get; set; }
        public int? MchId { get; set; }
    }
}
