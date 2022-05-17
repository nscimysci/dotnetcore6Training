using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class MstConfiguration
    {
        public int ConId { get; set; }
        public string ConKey { get; set; }
        public string ConValue { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
