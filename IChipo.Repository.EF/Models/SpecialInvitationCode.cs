using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class SpecialInvitationCode
    {
        public int Id { get; set; }
        public string InvitationCode { get; set; }
        public int? ActivationCount { get; set; }
        public int? ActivationedCount { get; set; }
        public string SalesmanCode { get; set; }
        public string SalesmanName { get; set; }
        public string SalesmanPhone { get; set; }
        public string ReferrerCode { get; set; }
        public string ReferrerName { get; set; }
        public string ReferrerPhone { get; set; }
        public decimal? ReferrerRate { get; set; }
        public decimal? BusinessRateD0 { get; set; }
        public decimal? BusinessRateD1 { get; set; }
        public int? FeeType { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
        public int? ReferrerRateType { get; set; }
        public int? SalesmanId { get; set; }
        public int? ReferrerId { get; set; }
        public int? State { get; set; }
    }
}
