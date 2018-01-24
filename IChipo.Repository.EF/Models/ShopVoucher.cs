using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ShopVoucher
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int GoodsId { get; set; }
        public string GoodsName { get; set; }
        public decimal VoucherValue { get; set; }
        public int Status { get; set; }
        public int WithdrawId { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? UseTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
