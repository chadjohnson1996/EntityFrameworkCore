using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlTm
    {
        public int CompanyNo { get; set; }
        public decimal? GlIncome { get; set; }
        public decimal? GlAr { get; set; }
        public decimal? GlRetainage { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ControlDateFlag { get; set; }
        public string DefaultEditWorksheetMode { get; set; }
        public string DefaultEditInvoiceMode { get; set; }
        public string TaxLabor { get; set; }
        public string TaxMaterial { get; set; }
        public string TaxSubcontract { get; set; }
        public string TaxOwnedEquipment { get; set; }
        public string TaxRentedEquipment { get; set; }
        public string TaxBurden { get; set; }
        public string TaxOverhead { get; set; }
        public int? TmBillingDesignNo { get; set; }
        public string DefaultBillingDesignSequence { get; set; }
        public string ManualTrxEntry { get; set; }
        public string ClosedJobEntry { get; set; }
        public string DefaultDivToJobCreditGl { get; set; }
        public string DefaultDivToJobDebitGl { get; set; }
        public int? DefaultDiv1 { get; set; }
        public int? DefaultDiv2 { get; set; }
        public int? DefaultDiv3 { get; set; }
        public int? DefaultDiv4 { get; set; }
        public string IncludeTaxInRetainage { get; set; }
        public string InvoiceDateDefault { get; set; }
        public string TermsNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string TermsId { get; set; }
        public string TmBillingDesignId { get; set; }
        public string InvUsageMarkup { get; set; }
        public string PricingMethod { get; set; }
        public string IncludeInArPercentComplete { get; set; }
        public string SecuredEmployeeCost { get; set; }
        public string WksheetRegatherDeletedRow { get; set; }
        public string UsetaxLabor { get; set; }
        public string UsetaxMaterial { get; set; }
        public string UsetaxSubcontract { get; set; }
        public string UsetaxOwnedEquipment { get; set; }
        public string UsetaxRentedEquipment { get; set; }
        public string UsetaxBurden { get; set; }
        public string UsetaxOverhead { get; set; }
        public string UsePayRateSecurity { get; set; }
        public string SuppressRateTypeFlag { get; set; }
        public int? TmWsDesignNo { get; set; }
        public string DefaultWsDesignSequence { get; set; }
        public string ProtectCustomerFlag { get; set; }
        public string TmWsDesignId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts Accounts1 { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public Terms Terms { get; set; }
        public DsgDesigns TmBillingDesignNoNavigation { get; set; }
    }
}
