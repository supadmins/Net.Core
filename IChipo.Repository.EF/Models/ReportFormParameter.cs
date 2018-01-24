using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ReportFormParameter
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? ParameterType { get; set; }
        public string DefaultValue { get; set; }
        public bool? IsAllowNull { get; set; }
        public string Name { get; set; }
        public string ParameterRegex { get; set; }
        public string Tip { get; set; }
        public int? ReportFormId { get; set; }
    }
}
