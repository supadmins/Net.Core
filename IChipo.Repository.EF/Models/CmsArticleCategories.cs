using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class CmsArticleCategories
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CmsArticles CmsArticles { get; set; }
    }
}
