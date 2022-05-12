using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstProcurementDepartment
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string PrefixProjcetCode { get; set; }
        public int RunningNo { get; set; }
        public int Year { get; set; }
    }
}
