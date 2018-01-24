using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class WithdrawalRecord
    {
        public int Id { get; set; }
        public int Source { get; set; }
        public string SourceOrderNo { get; set; }
        public string OrderNo { get; set; }
        public string OutTradeOrderNo { get; set; }
        public int Amount { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public string ClientIdAddress { get; set; }
        public string WeixinAppId { get; set; }
        public string WeixinOpenId { get; set; }
        public string BankCardNo { get; set; }
        public string BankName { get; set; }
        public string BankGodName { get; set; }
        public int? BankType { get; set; }
        public string BankUnionNo { get; set; }
        public string CallBackUrl { get; set; }
        public bool? CallBackIsHandled { get; set; }
        public int? CallBackCount { get; set; }
        public string Attach { get; set; }
        public string FailureMsg { get; set; }
        public DateTime? FinishDateTime { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
