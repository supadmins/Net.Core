using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AutoSettleApply
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public string ShopkeeperName { get; set; }
        public string Address { get; set; }
        public string AddressDeatil { get; set; }
        public int? AreaId { get; set; }
        public string BusinessLicense { get; set; }
        public string Doorway { get; set; }
        public string IdNumber { get; set; }
        public string IdcardNegative { get; set; }
        public string IdcardPositive { get; set; }
        public int BankCardType { get; set; }
        public string BankCardNo { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankAreaCode { get; set; }
        public string BankProvincial { get; set; }
        public string BankCity { get; set; }
        public string BranchBankName { get; set; }
        public string CardholderName { get; set; }
        public string BankCardPhoneNumber { get; set; }
        public string BankCardSerialNumber { get; set; }
        public int SettlementMode { get; set; }
        public decimal CashInRateT0 { get; set; }
        public decimal CashInRateT1 { get; set; }
        public int AuditStatus { get; set; }
        public DateTime? AuditDateTime { get; set; }
        public int MchSettingStatus { get; set; }
        public double PointLongitude { get; set; }
        public double Latitude { get; set; }
        public string Remark { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsValid { get; set; }
        public bool? IsCheckLegalPerson { get; set; }
        public string LegalPersonReason { get; set; }
        public bool? IsCheckPic { get; set; }
        public string PicReason { get; set; }
        public bool? IsCheckSettleInfo { get; set; }
        public string SettleInfoReason { get; set; }
        public string SupplyMsg { get; set; }
        public string PosAgreement { get; set; }
        public string PosLicence { get; set; }
        public string Indoor { get; set; }
    }
}
