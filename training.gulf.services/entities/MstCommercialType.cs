using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstCommercialType
    {
        public int Id { get; set; }
        public string CommercialTypeName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
