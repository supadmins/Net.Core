using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ReferrerQrCodeTicket
    {
        public int Id { get; set; }
        public int ReferrerUserId { get; set; }
        public string Ticket { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
        public int? Type { get; set; }
        public string InviteCode { get; set; }
    }
}
