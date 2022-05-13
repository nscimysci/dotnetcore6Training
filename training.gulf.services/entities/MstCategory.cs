using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
