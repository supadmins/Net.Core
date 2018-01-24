using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class SysSms
    {
        public int Id { get; set; }
        public string AppId { get; set; }
        public int Type { get; set; }
        public int Provider { get; set; }
        public string SendPhoneNumber { get; set; }
        public string SendContent { get; set; }
        public bool Success { get; set; }
        public string Remark { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
    }
}
