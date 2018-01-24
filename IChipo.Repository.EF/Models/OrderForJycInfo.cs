using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class OrderForJycInfo
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string OrderNo { get; set; }
        public bool IsChecked { get; set; }
        public string Name { get; set; }
        public string RoomNum { get; set; }
        public int Type { get; set; }
        public string Remarks { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
        public DateTime? CheckedTime { get; set; }
    }
}
