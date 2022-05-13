using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class TrnAttachment
    {
        public int Id { get; set; }
        public string Module { get; set; } = null!;
        public int? ProjectId { get; set; }
        public int? VendorId { get; set; }
        public string FilePath { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public int AttachmentTypeId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
