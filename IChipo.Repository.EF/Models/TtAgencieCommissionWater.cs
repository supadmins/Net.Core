﻿using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TtAgencieCommissionWater
    {
        public int Id { get; set; }
        public int? AgencyId { get; set; }
        public decimal? AgencySettleRate { get; set; }
        public int? ShopId { get; set; }
        public decimal? ShopSettleRate { get; set; }
        public int? RelationId { get; set; }
        public decimal? TradeAmount { get; set; }
        public decimal? CommissionAmount { get; set; }
        public bool? IsOutBill { get; set; }
        public DateTime? StatisticDate { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
