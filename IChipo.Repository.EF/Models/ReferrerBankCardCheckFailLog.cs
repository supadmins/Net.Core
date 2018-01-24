using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ReferrerBankCardCheckFailLog
    {
        public int Id { get; set; }
        public int ReferrerUserId { get; set; }
        public string IdcardNumber { get; set; }
        public string CardNumber { get; set; }
        public string RealName { get; set; }
        public string Phone { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
