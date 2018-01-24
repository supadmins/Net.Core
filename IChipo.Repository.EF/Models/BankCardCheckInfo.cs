using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class BankCardCheckInfo
    {
        public int Id { get; set; }
        public string IdcardNumber { get; set; }
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
