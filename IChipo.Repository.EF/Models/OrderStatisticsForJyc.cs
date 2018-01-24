using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class OrderStatisticsForJyc
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalFee { get; set; }
        public int TotalCount { get; set; }
        public decimal PropertyAmount { get; set; }
        public decimal PropertyFee { get; set; }
        public int PropertyCount { get; set; }
        public decimal RentalAmount { get; set; }
        public decimal RentalFee { get; set; }
        public int RentalCount { get; set; }
        public DateTime StatisticsDate { get; set; }
        public string Remark { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
