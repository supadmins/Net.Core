using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class WeiXinMchSetting
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string AppId { get; set; }
        public string MchId { get; set; }
        public string Key { get; set; }
        public string CerPath { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
