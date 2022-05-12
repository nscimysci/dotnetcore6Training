using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstCompany
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyFullName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
