using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class TrnSerwayH
    {
        public int SerwayHid { get; set; }
        public string SerweyCode { get; set; }
        public int? ProjectId { get; set; }
        public int? VendorId { get; set; }
        public string ProductType { get; set; }
        public string SerwayComment { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
