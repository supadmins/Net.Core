using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class IndustriesCommentConfig
    {
        public int Id { get; set; }
        public int IndustriesId { get; set; }
        public int FirstComment { get; set; }
        public int SecondComment { get; set; }
        public int ThirdComment { get; set; }
        public int FourthComment { get; set; }
        public int FifthComment { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
    }
}
