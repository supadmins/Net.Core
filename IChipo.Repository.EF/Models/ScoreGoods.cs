﻿using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ScoreGoods
    {
        public int Id { get; set; }
        public string GoodsName { get; set; }
        public int? Type { get; set; }
        public int? Price { get; set; }
        public int? GoodsCount { get; set; }
        public string GoodsBody { get; set; }
        public decimal VoucherValue { get; set; }
        public bool IsHot { get; set; }
        public bool IsNew { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
