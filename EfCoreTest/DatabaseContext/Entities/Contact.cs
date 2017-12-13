using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Contact
    {
        public string OutsideSalesPersonNo { get; set; }
        public string InsideSalesPersonNo { get; set; }
        public string ContactNo { get; set; }
        public string ContactPersonNo { get; set; }
        public string TimeZoneNo { get; set; }
        public string StatusNo { get; set; }
        public string SpecialityNo { get; set; }
        public int CompanyNo { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneVoice { get; set; }
        public string PhoneFax { get; set; }
        public string PhoneData { get; set; }
        public string Phone800 { get; set; }
        public string EmailAddress { get; set; }
        public string WebAddress { get; set; }
        public string StateRatingNo { get; set; }
        public int? LowEmployeeSize { get; set; }
        public string AnnualSales { get; set; }
        public DateTime? MailingStatusDate { get; set; }
        public string LeadStrengthNo { get; set; }
        public DateTime? SecondDemoDate { get; set; }
        public DateTime? ExpectedCloseDate { get; set; }
        public DateTime? FirstDemoDate { get; set; }
        public string FirstDemoType { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string RowModifiedBy { get; set; }
        public string RecordStatus { get; set; }
        public int RowUniqueId { get; set; }
        public string SecondDemoType { get; set; }
        public string ResponseNo { get; set; }
        public string CallCenterSalesPersonNo { get; set; }
        public string CompetitorNo { get; set; }
        public string SicCodeNo { get; set; }
        public int? PeakEmployeeSize { get; set; }
        public string ClassificationNo { get; set; }
        public string AssociationNo { get; set; }
        public string CpaFirm { get; set; }
        public string AssociationId { get; set; }
        public string CallCenterSalesPersonId { get; set; }
        public string ClassificationId { get; set; }
        public string CompanyId { get; set; }
        public string CompetitorId { get; set; }
        public string ContactId { get; set; }
        public string ContactPersonId { get; set; }
        public string InsideSalesPersonId { get; set; }
        public string LeadStrengthId { get; set; }
        public string OutsideSalesPersonId { get; set; }
        public string ResponseId { get; set; }
        public string SicCodeId { get; set; }
        public string SpecialityId { get; set; }
        public string StateRatingId { get; set; }
        public string StatusId { get; set; }
        public string TimeZoneId { get; set; }
    }
}
