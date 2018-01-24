using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class RegisterApply
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ReferrerPhoneNumber { get; set; }
        public int? ReferrerGodId { get; set; }
        public int? ReferrerShopId { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
        public int? Status { get; set; }
        public string Remark { get; set; }
    }
}
