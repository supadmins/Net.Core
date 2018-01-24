using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class BonusPoolsLog
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int ShopGodId { get; set; }
        public int FansGodId { get; set; }
        public int RelationId { get; set; }
        public decimal? RelationAmount { get; set; }
        public decimal? InPoolsAmount { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
        public int LogType { get; set; }
        public decimal BonusPoolsBalance { get; set; }
    }
}
