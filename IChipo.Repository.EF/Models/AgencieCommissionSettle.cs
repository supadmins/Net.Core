using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AgencieCommissionSettle
    {
        public int Id { get; set; }
        public int? AgencyId { get; set; }
        public int? SettleComissionType { get; set; }
        public int? SettleCount { get; set; }
        public string Info { get; set; }
        public int? SettleStatus { get; set; }
        public decimal? NeedSettleAmount { get; set; }
        public decimal? SettedAmount { get; set; }
        public decimal? NotSettleAmount { get; set; }
        public string SettleDateRange { get; set; }
        public int? SettleDateUnit { get; set; }
        public DateTime? StatisticDate { get; set; }
        public bool? IsOnline { get; set; }
        public string OutTradeNo { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
