using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class CommentImage
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public string ImageUrl { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
