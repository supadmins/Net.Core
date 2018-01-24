using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TtGod
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
        public string Md5Secret { get; set; }
        public string Salt { get; set; }
        public string PhoneNumber { get; set; }
        public int? UserSource { get; set; }
        public string FullName { get; set; }
        public bool? IsValidPhone { get; set; }
        public bool? IsValidIdnumber { get; set; }
        public bool? IsValidEmail { get; set; }
        public string Email { get; set; }
        public string WeiXinOpenId { get; set; }
        public string IdNumber { get; set; }
        public int? RecommendGodId { get; set; }
        public DateTime? RecommendDateTime { get; set; }
        public int? GodStatus { get; set; }
        public string BankName { get; set; }
        public string BankCardNumber { get; set; }
        public bool? IsBankCard { get; set; }
        public int? GodType { get; set; }
        public bool? IsWeiXinAccount { get; set; }
        public string RecommendCode { get; set; }
        public string HeadUrl { get; set; }
        public string RecommendQrUrl { get; set; }
        public string NickName { get; set; }
        public int? Pid { get; set; }
        public string CardImg { get; set; }
        public decimal? WithdrawalFee { get; set; }
        public int? BankType { get; set; }
        public string BankUnionNo { get; set; }
        public int? SetWithdrawalType { get; set; }
        public int? SetWithdrawalMode { get; set; }
        public int? SetSettlementMode { get; set; }
        public int TotalScore { get; set; }
        public bool IsBusiness { get; set; }
        public int CommentTotal { get; set; }
        public int? FirstPayShopId { get; set; }
        public bool IsWechatFans { get; set; }
        public int RegistSource { get; set; }
        public string Appid { get; set; }
        public bool? IsBindReferrer { get; set; }
        public string ReferrerPhone { get; set; }
    }
}
