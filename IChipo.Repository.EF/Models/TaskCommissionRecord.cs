using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TaskCommissionRecord
    {
        public int Id { get; set; }
        public string RecordNo { get; set; }
        public int FeeType { get; set; }
        public int TaskId { get; set; }
        public int OrderId { get; set; }
        public int ShopId { get; set; }
        public int GodId { get; set; }
        public decimal Amount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
