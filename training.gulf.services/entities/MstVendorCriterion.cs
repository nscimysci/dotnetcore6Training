using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstVendorCriterion
    {
        public int VendorCriterialId { get; set; }
        public string Name { get; set; } = null!;
        public string Unit { get; set; } = null!;
        public string? RefTable { get; set; }
        public string? RefColum { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; } = null!;
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
    }
}
