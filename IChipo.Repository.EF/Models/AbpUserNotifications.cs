﻿using System;
using System.Collections.Generic;

namespace IChipo.Repository.EF.Models
{
    public partial class AbpUserNotifications
    {
        public Guid Id { get; set; }
        public int? TenantId { get; set; }
        public long UserId { get; set; }
        public Guid TenantNotificationId { get; set; }
        public int State { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
