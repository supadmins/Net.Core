using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class SendSmsLog
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? ExpiredTime { get; set; }
        public bool? IsUse { get; set; }
        public int? SmsType { get; set; }
    }
}
