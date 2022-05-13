using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstSerwayForm
    {
        public int FormId { get; set; }
        public string? SerwayFormName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
