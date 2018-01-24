using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TtFundsFlow
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public decimal? Amount { get; set; }
        public int? IncomeGodId { get; set; }
        public int? PayGodId { get; set; }
        public int? FeeType { get; set; }
        public int? RelationId { get; set; }
        public int? FeeStatus { get; set; }
        public string PayRemark { get; set; }
        public string IncomeRemark { get; set; }
        public int? CurrencyType { get; set; }
        public int? FeeOutInStatus { get; set; }
    }
}
