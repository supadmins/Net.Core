using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AgSerialNo
    {
        public int Id { get; set; }
        public int AgenciesId { get; set; }
        public string Prefix { get; set; }
        public string Value { get; set; }
        public byte FactorLength { get; set; }
    }
}
