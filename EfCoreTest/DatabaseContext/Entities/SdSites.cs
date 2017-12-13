using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdSites
    {
        public string Company { get; set; }
        public string SiteNumber { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string VoicePhone { get; set; }
        public string FaxPhone { get; set; }
        public string MobilePagerPhone { get; set; }
        public string Contact { get; set; }
        public string Attention { get; set; }
        public string Terms { get; set; }
        public string Salesperson { get; set; }
        public string Territory { get; set; }
        public string FinanceCharg { get; set; }
        public string TaxExemptNumber { get; set; }
        public string DefaultGlAccount { get; set; }
        public string DefaultJobActivity { get; set; }
        public string Notes { get; set; }
        public decimal? DiscountPercent { get; set; }
        public int? CalcDiscDays { get; set; }
        public int? CalcDiscDayOfMo { get; set; }
        public int? CalcDueDays { get; set; }
        public int? CalcDueDayOfMo { get; set; }
        public string CustomerNumber { get; set; }
        public string TaxAuthority { get; set; }
        public string JobNumber { get; set; }
        public string User4 { get; set; }
        public string EmailAddress { get; set; }
        public decimal? CreditLimit { get; set; }
        public string ChargecardType { get; set; }
        public string ChargecardNumber { get; set; }
        public DateTime? ChargecardExpiration { get; set; }
        public string ChargecardOwner { get; set; }
        public string DefaultGlBranch { get; set; }
        public string ChargecardPin { get; set; }
        public string HowdidyouHearaboutus { get; set; }
        public string HoldFlag { get; set; }
        public string SiteJobOverride { get; set; }
        public string SiteJobStatus { get; set; }
        public DateTime? SiteJobClosedate { get; set; }
        public string PayrollLocalTax { get; set; }
        public int? DefaultRepairType { get; set; }
        public int RowUniqueId { get; set; }
        public string SiteNote { get; set; }
        public int? WoDesign { get; set; }
        public string IncomeTypeNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int? CompanyNo { get; set; }
        public string ForeignFlag { get; set; }
        public string Country { get; set; }
        public string FlatRateNo { get; set; }
        public string DefaultPriceLevel { get; set; }
        public string CompanyId { get; set; }
        public string FlatRateId { get; set; }
        public string IncomeTypeId { get; set; }
        public int? DefaultTmDesign { get; set; }
        public string DefaultLaborPriceLevel { get; set; }
        public string PhaseNo { get; set; }
        public string ShipToNo { get; set; }
        public string PhaseId { get; set; }
        public string ShipToId { get; set; }
        public string SdTermsNo { get; set; }
        public string GeoArea { get; set; }
        public string SdTermsId { get; set; }
        public string PriorityCode { get; set; }
        public int? OrdinalPosition { get; set; }
        public int? TmWsDesignNo { get; set; }
        public string TmWsDesignId { get; set; }

        public Terms TermsNavigation { get; set; }
    }
}
