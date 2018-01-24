using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class OrderRefund
    {
        public int Id { get; set; }
        public string RefundNo { get; set; }
        public int OrderId { get; set; }
        public string OrderNo { get; set; }
        public decimal OrderAmount { get; set; }
        public decimal RefundAmount { get; set; }
        public string TransactionNo { get; set; }
        public string TransactionRefundNo { get; set; }
        public int? RefundStatus { get; set; }
        public string RefundChannel { get; set; }
        public DateTime? RefundTime { get; set; }
        public string Remark { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
