using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ShopActivityCoupon
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int BranchShopId { get; set; }
        public int Type { get; set; }
        public decimal FaceValue { get; set; }
        public int Count { get; set; }
        public DateTime UseBeginTime { get; set; }
        public DateTime UseEndTime { get; set; }
        public decimal UseMinValue { get; set; }
        public DateTime SendBeginTime { get; set; }
        public DateTime SendEndTime { get; set; }
        public decimal SendMinValue { get; set; }
        public int Status { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool? IsValid { get; set; }
        public string CozyCue { get; set; }
        public int InitCount { get; set; }
        public int ValidDay { get; set; }
    }
}
