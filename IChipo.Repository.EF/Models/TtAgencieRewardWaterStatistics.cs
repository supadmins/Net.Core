using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TtAgencieRewardWaterStatistics
    {
        public int Id { get; set; }
        public int? AgencyId { get; set; }
        public int? ShopId { get; set; }
        public int? QrCodeId { get; set; }
        public decimal? PayAmount { get; set; }
        public DateTime? ActiveDateTime { get; set; }
        public decimal? ActiveRewardAmount { get; set; }
        public bool? IsOutBill { get; set; }
        public DateTime? StatisticDate { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
