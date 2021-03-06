﻿using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class GroupBuyRelationGod
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? GroupBuyId { get; set; }
        public int? GodId { get; set; }
        public bool? IsPay { get; set; }
        public DateTime? PayTime { get; set; }
        public bool? IsTeamLeader { get; set; }
    }
}
