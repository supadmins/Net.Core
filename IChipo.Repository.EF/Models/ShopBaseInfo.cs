using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ShopBaseInfo
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
        public string SubName { get; set; }
        public int? AreaId { get; set; }
        public double? Latitude { get; set; }
        public double? PointLongitude { get; set; }
        public string TelePhone { get; set; }
        public int? ShopType { get; set; }
        public int? IndustriesId { get; set; }
        public string BusinessLicense { get; set; }
        public string Logo { get; set; }
        public string Doorway { get; set; }
        public string Address { get; set; }
        public string BusinessCertificate { get; set; }
    }
}
