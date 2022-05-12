using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class TrnProjectQa
    {
        public int ProjectQaid { get; set; }
        public int ProjectId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int VendorId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
