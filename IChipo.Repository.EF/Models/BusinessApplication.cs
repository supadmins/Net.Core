using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class BusinessApplication
    {
        public int Id { get; set; }
        public int ApplyType { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string InviteCode { get; set; }
        public string Address { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
        public string Remarks { get; set; }
        public int State { get; set; }
    }
}
