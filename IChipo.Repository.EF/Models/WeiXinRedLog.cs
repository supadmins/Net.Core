using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class WeiXinRedLog
    {
        public int Id { get; set; }
        public decimal? Amount { get; set; }
        public string WeiXinOpenId { get; set; }
        public string RedNo { get; set; }
        public string PlatformNo { get; set; }
        public string TransactionNo { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Remarks { get; set; }
        public string OrderNo { get; set; }
    }
}
