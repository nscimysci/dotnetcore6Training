using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstSerwayList
    {
        public int ListId { get; set; }
        public int? FormId { get; set; }
        public string? ListTitle { get; set; }
        public string? ListSubject { get; set; }
        public string? ListDescription { get; set; }
        public string? ListRole { get; set; }
        public int? ListScore { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
