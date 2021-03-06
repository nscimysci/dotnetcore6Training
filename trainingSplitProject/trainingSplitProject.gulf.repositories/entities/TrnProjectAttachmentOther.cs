using System;
using System.Collections.Generic;

namespace trainingSplitProject.gulf.repositories.entities
{
    public partial class TrnProjectAttachmentOther
    {
        public int AttachmentId { get; set; }
        public int ProjectId { get; set; }
        public int AttachmentTypeId { get; set; }
        public int Seq { get; set; }
        public string FileName { get; set; } = null!;
        public string FileFullName { get; set; } = null!;
        public string? Description { get; set; }
        public string? Password { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; } = null!;
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
