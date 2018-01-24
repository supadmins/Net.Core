using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TtQrcodePayApply
    {
        public int Id { get; set; }
        public int? QrcodeId { get; set; }
        public int? ShopId { get; set; }
        public string ShopName { get; set; }
        public string Idcard { get; set; }
        public string Phone { get; set; }
        public int? Status { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string UserName { get; set; }
        public string WeiXinOpenId { get; set; }
        public string QrcodeNo { get; set; }
        public int BranchShopId { get; set; }
        public string WxpayAppId { get; set; }
    }
}
