using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class TrnProjectSelectVendorAttachment
    {
        public int AttachId { get; set; }
        public int ProjectId { get; set; }
        public int VendorId { get; set; }
        public string? AttachFilePo { get; set; }
        public string? AttachFilePoname { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; } = null!;
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
