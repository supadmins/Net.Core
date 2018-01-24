using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AdBrowseLog
    {
        public int Id { get; set; }
        public int? AdId { get; set; }
        public string AdCode { get; set; }
        public string Ip { get; set; }
        public string OpenId { get; set; }
        public string NickName { get; set; }
        public string Adress { get; set; }
        public string HeadImg { get; set; }
        public string Sex { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public bool? IsFee { get; set; }
        public decimal? FeeAmount { get; set; }
        public bool? IsFlow { get; set; }
        public int? FlowSize { get; set; }
        public string Phone { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
