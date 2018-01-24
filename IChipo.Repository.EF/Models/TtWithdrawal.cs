using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TtWithdrawal
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public decimal? Amount { get; set; }
        public string Remark { get; set; }
        public int? Status { get; set; }
        public int? GodId { get; set; }
        public int? Mode { get; set; }
        public decimal? Fee { get; set; }
        public decimal? ActualFee { get; set; }
        public string BankCardInfo { get; set; }
        public string Number { get; set; }
        public int? Type { get; set; }
        public decimal? WithdrawalAmount { get; set; }
        public string OrderNo { get; set; }
        public int? SettlementMode { get; set; }
        public decimal? FeeRate { get; set; }
        public string BankCardNo { get; set; }
        public string BankCardName { get; set; }
        public string FullName { get; set; }
    }
}
