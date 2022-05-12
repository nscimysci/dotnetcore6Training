using System;
using System.Collections.Generic;

namespace demo.gulf.repositories.entities
{
    public partial class MstUnitOfMeasure
    {
        public int UnitOfMeasureId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
