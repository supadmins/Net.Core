using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ShopFullDiscount
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int BranchShopId { get; set; }
        public decimal UseMinValue { get; set; }
        public decimal DiscountValue { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool? IsValid { get; set; }
        public int Stauts { get; set; }
    }
}
