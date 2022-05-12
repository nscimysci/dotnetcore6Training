using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class TrnProject
    {
        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string Subject { get; set; }
        public string ProjectDescription { get; set; }
        public string ContactAddressEmployer { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DepartmentRequest { get; set; }
        public int ProjectOwnerId { get; set; }
        public int CompanyId { get; set; }
        public string ProcurementTeam { get; set; }
        public int PurchasingGroupId { get; set; }
        public int ContactPointId { get; set; }
        public string Phone { get; set; }
        public decimal ProjectTotalAmount { get; set; }
        public bool IsPublic { get; set; }
        public bool IsUserReview { get; set; }
        public bool IsPocrequire { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public int? CreateId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? ModifiedId { get; set; }
        public bool IsActive { get; set; }
        public string ProjectStatus { get; set; }
        public string Remark { get; set; }
        public int? RequesterId { get; set; }
        public string RequesterEmail { get; set; }
        public int? ApproveId { get; set; }
        public string ApproveBy { get; set; }
        public DateTime? ApproveDate { get; set; }
        public int? ApprovalId { get; set; }
        public string ApprovalName { get; set; }
        public string ApprovalEmail { get; set; }
        public string Prpo { get; set; }
        public string Ccmail { get; set; }
        public string ProcuementRemark { get; set; }
        public string Committee { get; set; }
        public DateTime? NegotiationEnddate1 { get; set; }
        public DateTime? NegotiationEnddate2 { get; set; }
        public DateTime? NegotiationEnddate3 { get; set; }
        public DateTime? NegotiationEnddate4 { get; set; }
        public DateTime? NegotiationEnddate5 { get; set; }
        public DateTime? NegotiationEnddate6 { get; set; }
        public int? NegotiationRound { get; set; }
        public string GeneralComment { get; set; }
    }
}
