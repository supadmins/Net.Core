﻿using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ShopCollectRecord
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public int? BranchShopId { get; set; }
        public int? GodId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
