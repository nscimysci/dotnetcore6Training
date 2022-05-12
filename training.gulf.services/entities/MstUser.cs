using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ProcurementDeptId { get; set; }
        public bool? IsVendorAdmin { get; set; }
        public bool? IsProjectAdmin { get; set; }
        public int? BudgetApproverNo { get; set; }
        public bool? IsTeamLeader { get; set; }
    }
}
