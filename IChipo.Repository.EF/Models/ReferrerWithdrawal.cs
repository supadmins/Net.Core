using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ReferrerWithdrawal
    {
        public int Id { get; set; }
        public int? ReferrerUserId { get; set; }
        public string OrderNo { get; set; }
        public string SerialNumber { get; set; }
        public decimal? ArrivalAmount { get; set; }
        public decimal WithdrawalAmount { get; set; }
        public decimal? Fee { get; set; }
        public decimal Balance { get; set; }
        public int? SettlementMode { get; set; }
        public int? WithdrawalWay { get; set; }
        public int WithdrawalStatus { get; set; }
        public string CardholderName { get; set; }
        public string BankCardNo { get; set; }
        public string BankName { get; set; }
        public string Remarks { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
