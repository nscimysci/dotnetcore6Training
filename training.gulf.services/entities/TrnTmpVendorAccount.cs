using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class TrnTmpVendorAccount
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string? CompanyName { get; set; }
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;
        public string? Status { get; set; }
        public bool? IsLock { get; set; }
        public int? TryCount { get; set; }
        public bool? IsNotiExpire { get; set; }
        public DateTime? LastestLogin { get; set; }
        public string? ApprovalStatus { get; set; }
        public int TmpHistoryId { get; set; }
    }
}
