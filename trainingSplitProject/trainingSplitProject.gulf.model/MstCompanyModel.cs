using System;
using System.Collections.Generic;

namespace trainingSplitProject.gulf.model
{
    public class MstCompanyModel
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string CompanyFullName { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; } = null!;
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public string CompanyTest { get; set; }
    }
}
