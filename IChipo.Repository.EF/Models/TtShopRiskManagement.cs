using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TtShopRiskManagement
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int ShopId { get; set; }
        public decimal DayTradeAmount { get; set; }
        public decimal SinglePayAmount { get; set; }
        public decimal DayWithdrawalAmount { get; set; }
        public decimal SingleWithdrawalAmount { get; set; }
        public bool IsEnabled { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
