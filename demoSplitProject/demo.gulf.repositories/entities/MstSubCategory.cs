using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class MstSubCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
