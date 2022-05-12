using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class TrnTmpVendorLocation
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public string UserName { get; set; }
        public int CountryId { get; set; }
        public int ProvinceId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int TmpHistoryId { get; set; }
        public int Idtmp { get; set; }
    }
}
