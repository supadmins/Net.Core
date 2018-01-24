using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class CmsArticles
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PicUrl { get; set; }
        public string Introduction { get; set; }
        public string LineUrl { get; set; }
        public string OriginalUrl { get; set; }
        public string Content { get; set; }
        public int ArticleCategoryId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }

        public CmsArticleCategories IdNavigation { get; set; }
    }
}
