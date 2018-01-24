using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class WeiXinMsgTemplateSetting
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string AppId { get; set; }
        public string TemplateId { get; set; }
        public string Title { get; set; }
        public string PrimaryIndustry { get; set; }
        public string DeputyIndustry { get; set; }
        public string Content { get; set; }
        public string Example { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
