using System;
using System.Collections.Generic;

namespace trainingSplitProject.gulf.repositories.entities
{
    public partial class TrnProjectVendorSubmitAttachment
    {
        public int ProjectVendorSubmitAttachId { get; set; }
        public int ProjectId { get; set; }
        public int VendorId { get; set; }
        public int Round { get; set; }
        public string? AttachFileBoq { get; set; }
        public string? AttachFileBoqname { get; set; }
        public string? AttachFileSpec { get; set; }
        public string? AttachFileSpecname { get; set; }
        public string? AttachFileTor { get; set; }
        public string? AttachFileTorname { get; set; }
        public string? AttachFileBoqprice { get; set; }
        public string? AttachFileBoqpriceName { get; set; }
        public string? AttachFileQuotation { get; set; }
        public string? AttachFileQuotationName { get; set; }
        public string? AttachFilePersonal { get; set; }
        public string? AttachFilePersonalName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; } = null!;
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public string? AttachFilePriceOfferConfirmation { get; set; }
        public string? AttachFilePriceOfferConfirmationName { get; set; }
        public string? AttachFileTechnicalProposal { get; set; }
        public string? AttachFileTechnicalProposalName { get; set; }
        public string? AttachFilePo { get; set; }
        public string? AttachFilePoname { get; set; }
    }
}
