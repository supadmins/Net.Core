using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AbpTenantInfo
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string BusinessLicenseUrl { get; set; }
        public string BusinessLicenseNo { get; set; }
        public string LegalPersonName { get; set; }
        public string LegalIdCard { get; set; }
        public string LegalIdCardUrl { get; set; }
        public string LegalIdCardReverseUrl { get; set; }
        public string Principal { get; set; }
        public string PrincipalPhone { get; set; }
        public string PrincipalEmail { get; set; }
        public int ProvinceId { get; set; }
        public int? CityId { get; set; }
        public int? District { get; set; }
        public string SettleAccountRealName { get; set; }
        public string SettleBankCardNo { get; set; }
        public string SettleBankName { get; set; }
        public string SettleSubBranchName { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }
        public long? DeleterUserId { get; set; }
        public int TenantId { get; set; }
    }
}
