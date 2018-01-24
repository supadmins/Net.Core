using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Content { get; set; }
        public int GodId { get; set; }
        public int ShopId { get; set; }
        public bool IsRead { get; set; }
        public string OrderNo { get; set; }
        public int OrderPayType { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
        public bool HasImage { get; set; }
        public string GodOpenId { get; set; }
        public int? EnjoyStatus { get; set; }
        public int CommentType { get; set; }
        public bool IsAnonymity { get; set; }
        public int BranchShopId { get; set; }
    }
}
