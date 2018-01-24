using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class BonusWithdrawal
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
        public decimal Amount { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
        public int GodId { get; set; }
        public int? Mode { get; set; }
        public decimal Fee { get; set; }
        public string BankCardInfo { get; set; }
        public string TransactionNo { get; set; }
        public int WithdrawalType { get; set; }
        public decimal? WithdrawalAmount { get; set; }
        public string OrderNo { get; set; }
        public int? SettlementMode { get; set; }
        public decimal? FeeRate { get; set; }
        public string BankCardNo { get; set; }
        public string FullName { get; set; }
        public string BankCardName { get; set; }
        public string GodPhoneNumber { get; set; }
        public int BankType { get; set; }
        public string BankUnionNo { get; set; }
        public int ShopAuthorizeSalesId { get; set; }
    }
}
