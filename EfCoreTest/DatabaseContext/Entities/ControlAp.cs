using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlAp
    {
        public ControlAp()
        {
            ControlApChameleonFieldMap = new HashSet<ControlApChameleonFieldMap>();
        }

        public int CompanyNo { get; set; }
        public decimal? GlCash { get; set; }
        public decimal? GlCashPrepaid { get; set; }
        public decimal? GlCashManual { get; set; }
        public decimal? GlAp { get; set; }
        public decimal? GlDiscount { get; set; }
        public decimal? GlRetainage { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ValidateDateRange { get; set; }
        public string UpdateGlHistory { get; set; }
        public string CondenseGl { get; set; }
        public string PrepaidDbcrFlag { get; set; }
        public string PrepaidFullpayPostFlag { get; set; }
        public string PreventAdjPaidVchr { get; set; }
        public string BatchVchrPostDt { get; set; }
        public string ShowDueDtInInquiry { get; set; }
        public string DefaultDivisionToJob { get; set; }
        public string OvrhdJobNo { get; set; }
        public string OvrhdPhaseNo { get; set; }
        public string OvrhdCostCodeNo { get; set; }
        public string OvrhdCostClassNo { get; set; }
        public decimal? Age1 { get; set; }
        public decimal? Age2 { get; set; }
        public decimal? Age3 { get; set; }
        public string FederalId { get; set; }
        public string FederalIdType { get; set; }
        public string InquiryVchrSortMethod { get; set; }
        public string InsPromptVchrEntry { get; set; }
        public string InsPromptPaymentEntry { get; set; }
        public string AutomaticWaiver { get; set; }
        public string DefaultWaiverType { get; set; }
        public string FinalLienWaiver { get; set; }
        public string DefaultVchrDtEntry { get; set; }
        public string TabFields { get; set; }
        public string RetainageRoundoff { get; set; }
        public string PayStatus { get; set; }
        public string EntryScreenFormat { get; set; }
        public string AllowZeroVoucher { get; set; }
        public string ForcePayclassVendor { get; set; }
        public string ForcePayclassVoucher { get; set; }
        public string ShowVendorSortName { get; set; }
        public string CheckDupInvEntry { get; set; }
        public string CheckDupInvPosted { get; set; }
        public string ForceJobSort { get; set; }
        public string CheckFormat { get; set; }
        public string WarnLowChecks { get; set; }
        public string PrinterTypeForCheck { get; set; }
        public string PrinterStubForCheck { get; set; }
        public string PrintWordsOnCheck { get; set; }
        public decimal? LeadingVoidsOnCheck { get; set; }
        public string PrintJobInvDesc { get; set; }
        public string PrintOptionalColumn { get; set; }
        public string DefaultVoidCheckDt { get; set; }
        public string FlagRetainageOnCheck { get; set; }
        public string FlagWithCharacter { get; set; }
        public string CondenseCheckStub { get; set; }
        public string TaxAuthAttached { get; set; }
        public string ForceTaxAuthOnGl { get; set; }
        public string SisAppendCharacter { get; set; }
        public string VerifyToVendorTaxAuth { get; set; }
        public string TaxAuthBalanceToInv { get; set; }
        public string RequirePo { get; set; }
        public string DisablePo { get; set; }
        public string DefaultVendorFromPo { get; set; }
        public string DefaultJobFromPo { get; set; }
        public string DefaultAmtFromPo { get; set; }
        public string DefaultChgordCcodes { get; set; }
        public string DefaultCcodesVchrEntry { get; set; }
        public string DefaultJcDistributionToPo { get; set; }
        public string PrintAddressOnPo { get; set; }
        public string PrintTitleOnPo { get; set; }
        public string DefaultPoRetainageToJob { get; set; }
        public string PoDefaultType { get; set; }
        public string PoFormat { get; set; }
        public string PoSubs { get; set; }
        public decimal? DetailLinesOnPo { get; set; }
        public string EnableEqpMaint { get; set; }
        public string EnableMatTicketing { get; set; }
        public string AllowJobsOnMtVchr { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string TermsNo { get; set; }
        public int? DefaultDiv1 { get; set; }
        public int? DefaultDiv2 { get; set; }
        public int? DefaultDiv3 { get; set; }
        public int? DefaultDiv4 { get; set; }
        public string DefaultSeqDiv1 { get; set; }
        public string DefaultSeqDiv2 { get; set; }
        public string CompanyId { get; set; }
        public string OvrhdCostClassId { get; set; }
        public string OvrhdCostCodeId { get; set; }
        public string OvrhdJobId { get; set; }
        public string OvrhdPhaseId { get; set; }
        public string TermsId { get; set; }
        public string EnableForeignPostalCode { get; set; }
        public string CheckPrintFont { get; set; }
        public string DefaultSeqGlExpense { get; set; }
        public string InsPromptPoEntry { get; set; }
        public string UseEmpMiscDescApInv { get; set; }
        public string ShowJobInq { get; set; }
        public DateTime? InvoiceDropdownStartDate { get; set; }
        public string ShowOpenNonpoRcpt { get; set; }
        public string IgnoreDueDate { get; set; }
        public string EnableChameleonIntegration { get; set; }
        public string ChameleonCabinet { get; set; }
        public string ChameleonLogonType { get; set; }
        public string ChameleonCredentials { get; set; }
        public string ChameleonWarnDifferentLogin { get; set; }
        public string AutoPostFlag { get; set; }
        public string InvoiceListDetailFlag { get; set; }
        public string InvoiceListDetailType { get; set; }
        public string InvoiceListSummaryFlag { get; set; }
        public string InvoiceListJobsummFlag { get; set; }
        public decimal? GlCreditCard { get; set; }
        public string InvoiceListDetailSort { get; set; }
        public string PositivePayPrDate { get; set; }
        public string CheckFont { get; set; }
        public string ApplyControlDateRecurring { get; set; }
        public string AllowNegativeToCash { get; set; }
        public string PayorNotice { get; set; }
        public string CertificateName1 { get; set; }
        public string CertificateName2 { get; set; }
        public string CertificateName3 { get; set; }
        public string CertificateName4 { get; set; }
        public string CertificateName5 { get; set; }
        public string PaymentSelectReturnToCriteria { get; set; }
        public string InsPromptVchrEntryDate { get; set; }
        public string InsPromptPoEntryDate { get; set; }
        public string ShowNotesOnAging { get; set; }
        public string SortInventoryOptions { get; set; }
        public string EnableEasyCheck { get; set; }
        public int? FederalIdEid { get; set; }
        public string PrintDollarSign { get; set; }
        public string TopCheck { get; set; }
        public string PrintCompanyOnStub { get; set; }

        public Edata FederalIdE { get; set; }
        public Terms Terms { get; set; }
        public ICollection<ControlApChameleonFieldMap> ControlApChameleonFieldMap { get; set; }
    }
}
