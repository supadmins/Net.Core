using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ActivistOrderForm
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? OrderFormId { get; set; }
        public string Remark { get; set; }
        public decimal? ReturnAmount { get; set; }
        public int? ReturnType { get; set; }
        public int? Sponsor { get; set; }
    }
}
