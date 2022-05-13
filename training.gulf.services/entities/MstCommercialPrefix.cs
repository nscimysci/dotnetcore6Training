using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstCommercialPrefix
    {
        public int Id { get; set; }
        public string? CommercialPrefixName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CommercialTypeId { get; set; }
    }
}
