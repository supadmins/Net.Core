using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class GuestCoupon
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int BranchShopId { get; set; }
        public string PhoneNumber { get; set; }
        public int CouponId { get; set; }
        public decimal FaceValue { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal UseMinValue { get; set; }
        public int Status { get; set; }
        public DateTime? UseTime { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public int SourceType { get; set; }
        public int SourceId { get; set; }
        public int IsView { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
