using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class TrnProjectSelectVendor
    {
        public int ProjectSelectVendorId { get; set; }
        public int ProjectId { get; set; }
        public int VendorId { get; set; }
        public string SelectedType { get; set; } = null!;
        public int BiddingRound { get; set; }
        public decimal? OfferGrandTotalAmount { get; set; }
        public int? DeliveryTime { get; set; }
        public int? IncoTerm { get; set; }
        public int? PaymentTerm { get; set; }
        public int? Warranty { get; set; }
        public string? Deviation { get; set; }
        public string? AdditionalInformation { get; set; }
        public decimal? ExperiencyWtgulfWhileBid { get; set; }
        public string? ProposalFileName { get; set; }
        public string? ProposalPassword { get; set; }
        public string? AttachmentFileName { get; set; }
        public string? AttachmentPassword { get; set; }
        public string? QuotationFileName { get; set; }
        public string? QuotationFilePassword { get; set; }
        public string? OtherFileName { get; set; }
        public string? OtherFilePassword { get; set; }
        public int? TechnicalScore { get; set; }
        public bool? IsAward { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; } = null!;
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public string? BiddingStatus { get; set; }
        public int? CurrencyId { get; set; }
        public bool? IsTechnicalPass { get; set; }
        public string? FirstOpenBy { get; set; }
        public DateTime? FirstOpenDate { get; set; }
        public string? TechnicalReviewRemark { get; set; }
        public decimal? CalculatedScore { get; set; }
        public decimal? TotalScore { get; set; }
        public bool? IsOffer { get; set; }
        public bool? IsSelectNego { get; set; }
        public int? PriceValid { get; set; }
        public bool? IsProcurementSubmitPo { get; set; }
        public bool? IsVendorSubmitPo { get; set; }
        public string? Ponumber { get; set; }
        public bool? IsGoodReceive { get; set; }
        public bool? IsTechnicalPassWtCondition { get; set; }
    }
}
