﻿using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AgencieScoreFlow
    {
        public int Id { get; set; }
        public int AgencyId { get; set; }
        public int? Score { get; set; }
        public int? Status { get; set; }
        public int? OutInStatus { get; set; }
        public int? Type { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
