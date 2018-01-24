using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AgencieOrder
    {
        public int Id { get; set; }
        public int AgencieId { get; set; }
        public string OrderNo { get; set; }
        public string OutTradeNo { get; set; }
        public int? PayMode { get; set; }
        public int? Status { get; set; }
        public int? OrderType { get; set; }
        public decimal? Amount { get; set; }
        public bool IsJoinPromotion { get; set; }
        public int? RelationId { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
