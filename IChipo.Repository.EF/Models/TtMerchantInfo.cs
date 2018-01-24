using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TtMerchantInfo
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int? Type { get; set; }
        public string Address { get; set; }
        public int? AreaId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int Id { get; set; }
        public decimal? D0rate { get; set; }
        public decimal? T1rate { get; set; }
        public int? Status { get; set; }
        public int? ShopId { get; set; }
        public string Phone { get; set; }
    }
}
