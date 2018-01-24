using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ExternalPayMerchant
    {
        public int Id { get; set; }
        public int ChannelId { get; set; }
        public int? AgencyId { get; set; }
        public int? AppId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public string MchId { get; set; }
        public string MchKey { get; set; }
        public decimal? WeightRatio { get; set; }
        public decimal? LimitAmount { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsJoinQueue { get; set; }
        public int? Sort { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
