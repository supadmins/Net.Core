using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class GrouponUserDetail
    {
        public int Id { get; set; }
        public int? GrouponDetailId { get; set; }
        public int? GodId { get; set; }
        public string WeiXinOpenId { get; set; }
        public string HeadImgUrl { get; set; }
        public bool? IsHead { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? GrouponId { get; set; }
        public string Ip { get; set; }
        public int? PaymentType { get; set; }
    }
}
