using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstCountry
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public int? CountryRuning { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
