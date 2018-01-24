using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AdOntoList
    {
        public int Id { get; set; }
        public int? Type { get; set; }
        public string Title { get; set; }
        public string Profiles { get; set; }
        public string Link { get; set; }
        public string Remark { get; set; }
        public string Cover { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Sort { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Code { get; set; }
        public int? BusinessId { get; set; }
        public string BusinessName { get; set; }
        public int? Status { get; set; }
        public string AuditUser { get; set; }
        public string AuditRemark { get; set; }
        public long? BrowseTotalCount { get; set; }
        public decimal? FeeRule { get; set; }
        public int? MaxFeeCount { get; set; }
        public int? MinFlowRule { get; set; }
        public int? MaxFlowRule { get; set; }
        public int? MaxFlowCount { get; set; }
        public string OntoOnLevel { get; set; }
        public string OntoAreaName { get; set; }
        public string OntoAreaCode { get; set; }
        public string AdSources { get; set; }
        public string Cnzzcode { get; set; }
    }
}
