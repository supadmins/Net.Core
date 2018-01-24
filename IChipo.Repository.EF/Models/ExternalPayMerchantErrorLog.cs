using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ExternalPayMerchantErrorLog
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string MchId { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
