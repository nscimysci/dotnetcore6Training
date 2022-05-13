using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class TrnVendorLocation
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public string? UserName { get; set; }
        public int CountryId { get; set; }
        public int ProvinceId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
