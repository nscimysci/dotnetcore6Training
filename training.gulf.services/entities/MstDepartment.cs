using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstDepartment
    {
        public int DeaprtmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int CompanyId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; } = null!;
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
