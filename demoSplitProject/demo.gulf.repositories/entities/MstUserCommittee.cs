using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class MstUserCommittee
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Status { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ProcurementDeptId { get; set; }
    }
}
