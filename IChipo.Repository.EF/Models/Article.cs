using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class Article
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime? ShowDateTime { get; set; }
        public int? ArticleSectionId { get; set; }
        public int? Sort { get; set; }
    }
}
