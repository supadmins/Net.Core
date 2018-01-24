﻿using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class OperationLog
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? GodId { get; set; }
        public string Remark { get; set; }
        public int? OperationType { get; set; }
    }
}
