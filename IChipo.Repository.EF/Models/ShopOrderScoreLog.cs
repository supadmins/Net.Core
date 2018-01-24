using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ShopOrderScoreLog
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int OrderId { get; set; }
        public string OrderNo { get; set; }
        public int OrderPayType { get; set; }
        public int GodId { get; set; }
        public int Score { get; set; }
        public int Type { get; set; }
        public string Remark { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
        public int ShopGodId { get; set; }
        public string GodOpenId { get; set; }
        public int BranchShopId { get; set; }
    }
}
