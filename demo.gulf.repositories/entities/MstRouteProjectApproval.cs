using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class MstRouteProjectApproval
    {
        public int RouteProjectApprovalId { get; set; }
        public int ProcurementDeptId { get; set; }
        public decimal BudgetMin { get; set; }
        public decimal BudgetMax { get; set; }
        public int BudgetApproverNo { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
