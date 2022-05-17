using System;
using System.Collections.Generic;

namespace trainingSplitProject.gulf.repositories.entities
{
    public partial class MstProcurementDepartment
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string PrefixProjcetCode { get; set; } = null!;
        public int RunningNo { get; set; }
        public int Year { get; set; }
    }
}
