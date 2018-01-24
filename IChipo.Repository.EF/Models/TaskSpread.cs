using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TaskSpread
    {
        public int Id { get; set; }
        public int SpreadType { get; set; }
        public int SpreadContentId { get; set; }
        public int WriteoffQuantity { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int CommisionCountWay { get; set; }
        public decimal? CommisionValue { get; set; }
        public decimal? CommisionMaxAmount { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public decimal CommisionTotalAmount { get; set; }
        public int State { get; set; }
        public bool? IsValid { get; set; }
        public int? ShopId { get; set; }
        public int? BranchShopId { get; set; }
    }
}
