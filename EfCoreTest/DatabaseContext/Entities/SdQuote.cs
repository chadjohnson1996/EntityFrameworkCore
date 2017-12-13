using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdQuote
    {
        public int CompanyNo { get; set; }
        public string QuoteNo { get; set; }
        public int? DispatchSequence { get; set; }
        public string LocationName { get; set; }
        public string LocationContact { get; set; }
        public string PhoneVoice { get; set; }
        public string PhoneFax { get; set; }
        public string PhoneMobile { get; set; }
        public string EmailAddress { get; set; }
        public string LocationAddress1 { get; set; }
        public string LocationAddress2 { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }
        public string LocationZip { get; set; }
        public string LocationForeignFlag { get; set; }
        public string LocationCountry { get; set; }
        public string WorkRequested { get; set; }
        public int? TypeOfRepair { get; set; }
        public string SiteNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string ContractNo { get; set; }
        public string Notes { get; set; }
        public string PurchaseOrder { get; set; }
        public string Warranty { get; set; }
        public string SalesPerson { get; set; }
        public decimal? SalesCommission { get; set; }
        public DateTime? DateOfQuote { get; set; }
        public int? WoDesign { get; set; }
        public string TaxAuthority { get; set; }
        public string Terms { get; set; }
        public string JobNumber { get; set; }
        public string FlatRateNo { get; set; }
        public string DefaultPriceLevel { get; set; }
        public string ContractNumber { get; set; }
        public string QuoteStatus { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? QuoteDesign { get; set; }
        public decimal TaxBase { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal BillingAmount { get; set; }
        public string CompanyId { get; set; }
        public string ContractId { get; set; }
        public string FlatRateId { get; set; }
        public string QuoteId { get; set; }
        public string QuoteStatusId { get; set; }
        public string DefaultLaborPriceLevel { get; set; }
        public int? ContractRenewalNo { get; set; }
        public string PriorityCode { get; set; }
        public string ContractRenewalId { get; set; }
    }
}
