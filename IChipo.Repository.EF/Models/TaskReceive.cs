using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TaskReceive
    {
        public int Id { get; set; }
        public int SpreadTaskId { get; set; }
        public int ReceiveSource { get; set; }
        public int RecipientId { get; set; }
        public int CommisionCountWay { get; set; }
        public decimal? CommisionValue { get; set; }
        public decimal? CommisionMaxAmount { get; set; }
        public string QrshareTaskCoupons { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
