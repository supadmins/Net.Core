using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class Files
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public int? FilesType { get; set; }
        public int? RelationId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? Sort { get; set; }
    }
}
