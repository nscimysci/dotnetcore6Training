using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class TrnProjectCommittee
    {
        public int ProjectId { get; set; }
        public int? Seq { get; set; }
        public int CommitteeId { get; set; }
        public string CommitteeName { get; set; }
        public string CommitteeEmail { get; set; }
        public bool? IsAttend { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
