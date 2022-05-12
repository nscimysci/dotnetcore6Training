using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class TrnProjectVendorCriterion
    {
        public int ProjectVendorCriteriaId { get; set; }
        public int ProjectId { get; set; }
        public int VendorCriteriaId { get; set; }
        public string Condition { get; set; }
        public decimal CriteriaValue { get; set; }
        public string CriteriaRequired { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
