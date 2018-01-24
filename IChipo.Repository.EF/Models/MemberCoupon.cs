using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class MemberCoupon
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int ShopId { get; set; }
        public int BranchShopId { get; set; }
        public int GodId { get; set; }
        public int CouponId { get; set; }
        public int OrderId { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal FaceValue { get; set; }
        public decimal UseMinValue { get; set; }
        public decimal OrderAmount { get; set; }
        public int Status { get; set; }
        public DateTime? UseTime { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool? IsValid { get; set; }
        public int SourceType { get; set; }
        public int SourceId { get; set; }
        public bool? IsView { get; set; }
    }
}
