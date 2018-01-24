using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class ShopAuthorizeSales
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int? GodId { get; set; }
        public int? ShopId { get; set; }
        public string ShopName { get; set; }
        public string Ip { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? Status { get; set; }
        public string Phone { get; set; }
        public string WeiXinOpenId { get; set; }
        public string UserHeardImg { get; set; }
        public string NickName { get; set; }
        public int? UserId { get; set; }
        public DateTime? ActivateTime { get; set; }
        public bool? IsWorkingTime { get; set; }
        public int BranchShopId { get; set; }
        public string Appid { get; set; }
        public bool IsCapitalAuthority { get; set; }
        public string SecurityCode { get; set; }
        public bool? IsLogin { get; set; }
        public int? IsVoicePush { get; set; }
        public string UnionId { get; set; }
        public string JgpushId { get; set; }
    }
}
