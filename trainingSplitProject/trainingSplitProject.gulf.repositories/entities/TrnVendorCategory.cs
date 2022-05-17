using System;
using System.Collections.Generic;

namespace trainingSplitProject.gulf.repositories.entities
{
    public partial class TrnVendorCategory
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? UserName { get; set; }
    }
}
