using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class TrnTmpVendorAccount
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Status { get; set; }
        public bool? IsLock { get; set; }
        public int? TryCount { get; set; }
        public bool? IsNotiExpire { get; set; }
        public DateTime? LastestLogin { get; set; }
        public string ApprovalStatus { get; set; }
        public int TmpHistoryId { get; set; }
    }
}
