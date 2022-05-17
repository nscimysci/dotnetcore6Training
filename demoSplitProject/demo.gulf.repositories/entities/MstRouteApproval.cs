using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class MstRouteApproval
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public string DepartmentName { get; set; }
        public string Level1 { get; set; }
        public string Level2 { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
