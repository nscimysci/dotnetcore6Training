using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class TrnProjectApprover
    {
        public int ProjectId { get; set; }
        public int? Seq { get; set; }
        public int ApproverId { get; set; }
        public string? ApproverName { get; set; }
        public string? ApproverEmail { get; set; }
        public bool? IsApproved { get; set; }
        public string? Remark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
