using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ApplyShopQuanlification
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? ShopId { get; set; }
        public string BusinessLicense { get; set; }
        public string IdcardPositive { get; set; }
        public string IdcardNegative { get; set; }
        public string TaxRegistration { get; set; }
        public int? ShopType { get; set; }
        public int? ProductTypeId { get; set; }
        public int? Mode { get; set; }
        public double? Latitude { get; set; }
        public double? DeliveryArea { get; set; }
        public double? PointLongitude { get; set; }
        public string Address { get; set; }
        public string Doorway { get; set; }
        public string BusinessCertificate { get; set; }
    }
}
