using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class TrnVendorAttachment
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string AttachmentType { get; set; }
        public string UserName { get; set; }
        public int? VendorId { get; set; }
        public int? NotiCount { get; set; }
    }
}
