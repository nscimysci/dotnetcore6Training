using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class TrnProjectVendorSubmitItem
    {
        public int ProjectVendorSubmiItemId { get; set; }
        public int ProjectId { get; set; }
        public int VendorId { get; set; }
        public int ProjectItemTemplateId { get; set; }
        public int Seq { get; set; }
        public decimal? OfferUnitPrice { get; set; }
        public bool? IsNoOffer { get; set; }
        public string RemarkNoOffer { get; set; }
        public decimal? OfferUnitPriceRound2 { get; set; }
        public bool? IsNoOfferRound2 { get; set; }
        public string RemarkNoOfferRound2 { get; set; }
        public decimal? OfferUnitPriceRound3 { get; set; }
        public bool? IsNoOfferRound3 { get; set; }
        public string RemarkNoOfferRound3 { get; set; }
        public decimal? OfferUnitPriceRound4 { get; set; }
        public bool? IsNoOfferRound4 { get; set; }
        public string RemarkNoOfferRound4 { get; set; }
        public decimal? OfferUnitPriceRound5 { get; set; }
        public bool? IsNoOfferRound5 { get; set; }
        public string RemarkNoOfferRound5 { get; set; }
        public decimal? OfferUnitPriceRound6 { get; set; }
        public bool? IsNoOfferRound6 { get; set; }
        public string RemarkNoOfferRound6 { get; set; }
        public string AttachFileBoq { get; set; }
        public string AttachFileBoqname { get; set; }
        public string AttachFileSpec { get; set; }
        public string AttachFileSpecname { get; set; }
        public string AttachFileTor { get; set; }
        public string AttachFileTorname { get; set; }
        public string AttachFileBoqprice { get; set; }
        public string AttachFileBoqpriceName { get; set; }
        public string AttachFileqQuotation { get; set; }
        public string AttachFileqQuotationName { get; set; }
        public string AttachFilePersonal { get; set; }
        public string AttachFilePersonalName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public bool? IsAward { get; set; }
        public string AwardSuggestRemark { get; set; }
        public bool? IsTechnicalPass { get; set; }
    }
}
