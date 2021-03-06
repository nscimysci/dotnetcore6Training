using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class TrnProjectWeight
    {
        public int ProjectWeightId { get; set; }
        public int ProjectId { get; set; }
        public int WeightId { get; set; }
        public int Seq { get; set; }
        public decimal Percentage { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; } = null!;
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
