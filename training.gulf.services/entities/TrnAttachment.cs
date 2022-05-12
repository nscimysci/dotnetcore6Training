using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class TrnAttachment
    {
        public int Id { get; set; }
        public string Module { get; set; }
        public int? ProjectId { get; set; }
        public int? VendorId { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public int AttachmentTypeId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
