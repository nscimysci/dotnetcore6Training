using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class TrnProjectAttachmentOther
    {
        public int AttachmentId { get; set; }
        public int ProjectId { get; set; }
        public int AttachmentTypeId { get; set; }
        public int Seq { get; set; }
        public string FileName { get; set; }
        public string FileFullName { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
