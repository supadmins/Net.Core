using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ArticleSection
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string Title { get; set; }
        public int? ParentId { get; set; }
        public int? Sort { get; set; }
    }
}
