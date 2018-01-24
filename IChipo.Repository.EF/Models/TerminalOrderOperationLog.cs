using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class TerminalOrderOperationLog
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string OrderNo { get; set; }
        public int ShopId { get; set; }
        public int BranchShopId { get; set; }
        public int OperationUserId { get; set; }
        public string OpreationUserName { get; set; }
        public string OperationUserPhoneNumber { get; set; }
        public string OperationUserOpenId { get; set; }
        public int OperationRoleType { get; set; }
        public string DeviceSn { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsValid { get; set; }
    }
}
