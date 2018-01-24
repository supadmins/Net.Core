using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class SmsTemplate
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? TemplateId { get; set; }
        public string TemplateContent { get; set; }
    }
}
