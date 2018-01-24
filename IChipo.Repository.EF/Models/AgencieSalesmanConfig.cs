﻿using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AgencieSalesmanConfig
    {
        public int Id { get; set; }
        public int AgencieId { get; set; }
        public string AgencieCode { get; set; }
        public int SeedValue { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
        public int? FactorLength { get; set; }
    }
}
