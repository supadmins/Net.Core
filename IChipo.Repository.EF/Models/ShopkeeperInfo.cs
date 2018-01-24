using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ShopkeeperInfo
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public string ShopkeeperName { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
        public string IdNumber { get; set; }
        public string IdCardInHand { get; set; }
        public string IdcardPositive { get; set; }
        public string IdcardNegative { get; set; }
    }
}
