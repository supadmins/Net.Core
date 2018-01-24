using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class BonusFundsFlow
    {
        public int Id { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool? IsValid { get; set; }
        public decimal? Amount { get; set; }
        public int FundsFlowType { get; set; }
        public int RelationId { get; set; }
        public string Remark { get; set; }
        public int GodId { get; set; }
        public int ShopId { get; set; }
        public decimal? RelationAmount { get; set; }
        public int ShopGodId { get; set; }
        public string GodNickName { get; set; }
        public string GodHeadUrl { get; set; }
        public bool IsInFlow { get; set; }
        public decimal BonusFundsBalance { get; set; }
        public int FeeStatus { get; set; }
    }
}
