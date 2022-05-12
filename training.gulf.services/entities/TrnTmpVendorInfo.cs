using System;
using System.Collections.Generic;

namespace training.gulf.services.entities
{
    public partial class TrnTmpVendorInfo
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public string TaxId { get; set; }
        public string BranchId { get; set; }
        public int CommercialPrefixId { get; set; }
        public string CompanyNameTh { get; set; }
        public string CompanyNameEn { get; set; }
        public int? CountryId { get; set; }
        public int? ProvinceId { get; set; }
        public int GulfContactPointId { get; set; }
        public DateTime? CertExpiryDate { get; set; }
        public string CompanyAddress { get; set; }
        public string CommercialType { get; set; }
        public string CompanyWebSite { get; set; }
        public DateTime? CompanyEstablishDate { get; set; }
        public decimal? CompanyTurnOver { get; set; }
        public int? NumberofEmployees { get; set; }
        public string CompanyTelephone { get; set; }
        public string CompanyContactPoint { get; set; }
        public string CompanyToEmail { get; set; }
        public string CompanyCcEmail { get; set; }
        public string Others { get; set; }
        public decimal? RegisteredCapital { get; set; }
        public string ExperienceIn { get; set; }
        public decimal? ExperienceYear { get; set; }
        public string Isoname { get; set; }
        public string LicenseName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CommercialTypeId { get; set; }
        public bool? IsConsent { get; set; }
        public string CompanyContactPointTel { get; set; }
        public string SapStreet { get; set; }
        public string SapStrSuppl1 { get; set; }
        public string SapStrSuppl2 { get; set; }
        public string SapHouseNum1 { get; set; }
        public string SapHouseNum2 { get; set; }
        public string SapStrSuppl3 { get; set; }
        public string SapLocation { get; set; }
        public string SapCity2 { get; set; }
        public string SapPostCode1 { get; set; }
        public string SapPostCity1 { get; set; }
        public string SapCountry { get; set; }
        public string SapLangu { get; set; }
        public string SapTelNumber { get; set; }
        public string SapMobNumber { get; set; }
        public string SapFaxNumber { get; set; }
        public string SapAdr6SmtpAddr { get; set; }
        public int TmpHistoryId { get; set; }
        public int Idtmp { get; set; }
    }
}
