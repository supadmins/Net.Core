using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ReferrerCodBinding
    {
        public int Id { get; set; }
        public string WeiXinOpenId { get; set; }
        public string ReferrerCode { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
        public int? Type { get; set; }
    }
}
