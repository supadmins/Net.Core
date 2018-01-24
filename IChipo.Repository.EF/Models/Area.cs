﻿using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class Area
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int? Sort { get; set; }
        public bool? IsDeliveryFeeLevel { get; set; }
    }
}
