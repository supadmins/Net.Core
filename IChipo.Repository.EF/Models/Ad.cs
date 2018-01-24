using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class Ad
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string Picture { get; set; }
        public string Url { get; set; }
        public int? AdType { get; set; }
        public int? Sort { get; set; }
        public string Title { get; set; }
        public int? Ext1 { get; set; }
        public string Ext2 { get; set; }
        public string Ext3 { get; set; }
        public string Ext4 { get; set; }
    }
}
