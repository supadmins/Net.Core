using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class SysArea
    {
        public int Id { get; set; }
        public string AreaName { get; set; }
        public int AreaType { get; set; }
        public int Pid { get; set; }
        public string Pcode { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
