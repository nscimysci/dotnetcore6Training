using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class MstUnitOfMeasure
    {
        public int UnitOfMeasureId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; } = null!;
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
