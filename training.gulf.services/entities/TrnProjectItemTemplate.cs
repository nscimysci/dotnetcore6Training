using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class TrnProjectItemTemplate
    {
        public int ProjectItemTemplateId { get; set; }
        public int ProjectId { get; set; }
        public int CompanyId { get; set; }
        public int Seq { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Quantity { get; set; }
        public int UnitOfMeasureId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalAmount { get; set; }
        public int ItemPeriod { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
