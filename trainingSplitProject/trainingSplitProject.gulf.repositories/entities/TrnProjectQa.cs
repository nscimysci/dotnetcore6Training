using System;
using System.Collections.Generic;

namespace trainingSplitProject.gulf.repositories.entities
{
    public partial class TrnProjectQa
    {
        public int ProjectQaid { get; set; }
        public int ProjectId { get; set; }
        public string Question { get; set; } = null!;
        public string Answer { get; set; } = null!;
        public int VendorId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; } = null!;
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
