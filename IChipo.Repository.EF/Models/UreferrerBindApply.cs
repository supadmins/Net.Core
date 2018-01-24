using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class UreferrerBindApply
    {
        public int Id { get; set; }
        public int? OutApplyId { get; set; }
        public int ReferrerId { get; set; }
        public string ReferrerCode { get; set; }
        public string ReferrerName { get; set; }
        public int ShopId { get; set; }
        public int Status { get; set; }
        public bool IsValid { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
