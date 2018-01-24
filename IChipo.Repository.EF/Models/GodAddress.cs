using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class GodAddress
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? GodId { get; set; }
        public bool? IsDefault { get; set; }
        public string Address { get; set; }
        public int? AreaId { get; set; }
        public double? PointLongitude { get; set; }
        public double? Latitude { get; set; }
        public string PhoneNumber { get; set; }
        public string LocateAddress { get; set; }
        public string Receiver { get; set; }
        public bool? Sex { get; set; }
    }
}
