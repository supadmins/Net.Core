using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ReferrerUser
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string OpenId { get; set; }
        public string Password { get; set; }
        public string SafePassword { get; set; }
        public string HeadPortrait { get; set; }
        public string NickName { get; set; }
        public string RealName { get; set; }
        public string IdcardNumber { get; set; }
        public string IdcardPositive { get; set; }
        public string IdcardNegative { get; set; }
        public string InvitationCode { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
        public int State { get; set; }
    }
}
