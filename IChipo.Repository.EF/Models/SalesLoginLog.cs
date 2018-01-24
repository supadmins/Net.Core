using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class SalesLoginLog
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public DateTime? LoginTime { get; set; }
        public string Ip { get; set; }
        public int? GodId { get; set; }
        public string WeiXinOpenId { get; set; }
        public string WeiXinNo { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
