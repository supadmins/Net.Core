using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class WeiXinMsgTemplates
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Templateld { get; set; }
        public string First { get; set; }
        public string FirstColor { get; set; }
        public string Remark { get; set; }
        public string RemarkColor { get; set; }
        public string Url { get; set; }
        public string JsonData { get; set; }
        public bool IsValid { get; set; }
        public bool IsAutoLogin { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? SendTime { get; set; }
        public int SendCount { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
    }
}
