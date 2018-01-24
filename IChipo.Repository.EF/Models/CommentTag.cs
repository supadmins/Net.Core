using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class CommentTag
    {
        public int Id { get; set; }
        public string CommentTagName { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
