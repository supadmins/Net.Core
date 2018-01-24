using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ReferrerFundsFlow
    {
        public int Id { get; set; }
        public int? ReferrerUserId { get; set; }
        public int Type { get; set; }
        public decimal Amount { get; set; }
        public bool IsInFlow { get; set; }
        public decimal Balance { get; set; }
        public int? RelationId { get; set; }
        public string Remarks { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
        public int? State { get; set; }
    }
}
