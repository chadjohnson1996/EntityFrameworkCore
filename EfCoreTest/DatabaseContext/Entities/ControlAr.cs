﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlAr
    {
        public int CompanyNo { get; set; }
        public decimal? GlIncome { get; set; }
        public decimal? GlCash { get; set; }
        public decimal? GlAr { get; set; }
        public decimal? GlRetainage { get; set; }
        public decimal? GlTax { get; set; }
        public string ManTrx { get; set; }
        public decimal? Age1 { get; set; }
        public decimal? Age2 { get; set; }
        public decimal? Age3 { get; set; }
        public string GlHisFlag { get; set; }
        public string WorkArea { get; set; }
        public decimal? GlServiceIncome { get; set; }
        public string DefaultRetainage { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ControlDateFlag { get; set; }
        public string CndGl { get; set; }
        public string ShowJobInq { get; set; }
        public string InvoiceDate { get; set; }
        public string IncludeTaxInRet { get; set; }
        public decimal? DueDays { get; set; }
        public string DueDaysType { get; set; }
        public decimal? DueCutoff { get; set; }
        public string PrintNameAdd { get; set; }
        public string SbClientScreen { get; set; }
        public decimal? GlRetainageHeld { get; set; }
        public decimal? GlNonArCash { get; set; }
        public string JobInvDesc { get; set; }
        public string AgingMethod { get; set; }
        public string AiaG702Type { get; set; }
        public string BypassIncTypeScrn { get; set; }
        public string MultiIncFlag { get; set; }
        public string AlwaysSendTax { get; set; }
        public decimal? SrvChrgPercent { get; set; }
        public decimal? SrvChrgPastDue { get; set; }
        public decimal? GlSrvChrgAr { get; set; }
        public decimal? GlSrvChrgIncome { get; set; }
        public string SrvChrgOvhdJobNo { get; set; }
        public string InvoiceFormat { get; set; }
        public string StatementFormat { get; set; }
        public string PrintGibNameAdd { get; set; }
        public string IgnoreItemVerify { get; set; }
        public string CombineGlScreen { get; set; }
        public string PrintInvoiceTitle { get; set; }
        public string AiaRounding { get; set; }
        public string LineItemCase { get; set; }
        public string EnableEqpIncome { get; set; }
        public string VerticleLines { get; set; }
        public string EnableProposal { get; set; }
        public string AiaWholeDollars { get; set; }
        public string AiaPostOn { get; set; }
        public string FloatTotal { get; set; }
        public decimal? NumberBodyLines { get; set; }
        public string DefaultInc { get; set; }
        public string InquireSequence { get; set; }
        public string ClosedJobEntry { get; set; }
        public string DivJobDebit { get; set; }
        public string DivJobCredit { get; set; }
        public string RollBackCur { get; set; }
        public string ItemizedFloatTot { get; set; }
        public string BlankQtyDec { get; set; }
        public string InvoicePrinterType { get; set; }
        public string ProposalFormat { get; set; }
        public string GlSubdivFlag { get; set; }
        public string DefaultInvoiceFormat { get; set; }
        public string ProprosalPrintType { get; set; }
        public string SrvChrgPercDollar { get; set; }
        public string SrvChrgInvAcct { get; set; }
        public string StoredMatRetPerc { get; set; }
        public string HiddenSalesTax { get; set; }
        public decimal? GlSlsTaxLiability { get; set; }
        public decimal? GlSlsTaxExpense { get; set; }
        public string SlsTaxPhaseNo { get; set; }
        public string SlsTaxCostCodeNo { get; set; }
        public string SlsTaxCostClassNo { get; set; }
        public string HiddenSalesDefault { get; set; }
        public string HiddenTaxType { get; set; }
        public string DefaultSeqPrcLvl { get; set; }
        public string CashTrxType { get; set; }
        public string MtItemType { get; set; }
        public decimal? MtConvFact1 { get; set; }
        public string MtConvUnit1 { get; set; }
        public decimal? MtConvFact2 { get; set; }
        public string MtConvUnit2 { get; set; }
        public decimal? MtConvFact3 { get; set; }
        public string MtConvUnit3 { get; set; }
        public string MtAllowModify { get; set; }
        public string EnableCcDist { get; set; }
        public string InvPrintPhone { get; set; }
        public string MtDateDefault { get; set; }
        public string DefaultAmtCshRcp { get; set; }
        public string MtToApFlag { get; set; }
        public string MtToApVendor { get; set; }
        public decimal? MtToApCost { get; set; }
        public decimal? DiscountDays { get; set; }
        public string DiscountDaysType { get; set; }
        public decimal? DiscountCutoff { get; set; }
        public string PreventAdjPaidInv { get; set; }
        public decimal? GlRentIncome { get; set; }
        public decimal? GlRentAr { get; set; }
        public string RentTaxNo { get; set; }
        public string RentTerms { get; set; }
        public string SalesrepCostClassNo { get; set; }
        public string DrawLowerBox { get; set; }
        public string AddJobRecord { get; set; }
        public decimal? RentMinBill { get; set; }
        public string RentLostItems { get; set; }
        public string RentInvoiceFormat { get; set; }
        public string RentSaleLvl { get; set; }
        public string RentTicketAuto { get; set; }
        public string RentUnitPriceFirst { get; set; }
        public string RentDefaultJob { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public decimal? GlDiscount { get; set; }
        public decimal? GlDeposit { get; set; }
        public string Terms { get; set; }
        public string TermsSequence { get; set; }
        public int? DefaultDiv1 { get; set; }
        public int? DefaultDiv2 { get; set; }
        public int? DefaultDiv3 { get; set; }
        public int? DefaultDiv4 { get; set; }
        public string ProtectPostSchedVal { get; set; }
        public string EnableInventoryInPrintInv { get; set; }
        public string AgingSummaryBasedOn { get; set; }
        public string AutoPostToAr { get; set; }
        public string EnableAutoPostAia { get; set; }
        public string IncludeStoredMatWhenPostAia { get; set; }
        public string CompanyId { get; set; }
        public string RentTaxId { get; set; }
        public string SalesrepCostClassId { get; set; }
        public string SlsTaxCostClassId { get; set; }
        public string SlsTaxCostCodeId { get; set; }
        public string SlsTaxPhaseId { get; set; }
        public string SrvChrgOvhdJobId { get; set; }
        public string DefaultIncomePhaseNo { get; set; }
        public string DefaultIncomeCostCodeNo { get; set; }
        public string DefaultIncomeCostCodeId { get; set; }
        public string DefaultIncomePhaseId { get; set; }
        public string UpdateInventory { get; set; }
        public string RemoveFrom { get; set; }
        public string FromJobNo { get; set; }
        public string FromWarehouseNo { get; set; }
        public string FromPhaseNo { get; set; }
        public string FromCostCodeNo { get; set; }
        public string FromCostClassNo { get; set; }
        public string ToPhaseNo { get; set; }
        public string ToCostCodeNo { get; set; }
        public string ToCostClassNo { get; set; }
        public int QuantityDecimals { get; set; }
        public int UnitPriceDecimals { get; set; }
        public string EnableAiaEscrowFields { get; set; }
        public string OverapplyDiscount { get; set; }
        public string FromCostClassId { get; set; }
        public string FromCostCodeId { get; set; }
        public string FromJobId { get; set; }
        public string FromPhaseId { get; set; }
        public string FromWarehouseId { get; set; }
        public string ToCostClassId { get; set; }
        public string ToCostCodeId { get; set; }
        public string ToPhaseId { get; set; }
        public string EnableServiceCharge { get; set; }
        public string SrvChrgBasedOn { get; set; }
        public string SrvChrgPhaseNo { get; set; }
        public string SrvChrgCostCodeNo { get; set; }
        public string SrvChrgIncludeBlankIncome { get; set; }
        public string IncludeJobNoInDesc { get; set; }
        public string SrvChrgCostCodeId { get; set; }
        public string SrvChrgPhaseId { get; set; }
        public string SeparateProposalFlag { get; set; }
        public string PreventClosedProposal { get; set; }
        public string PreventDeclinedProposal { get; set; }
        public string SeparateProposalPrefix { get; set; }
        public string PreventPendingProposal { get; set; }
        public string PostToHoldingAccount { get; set; }
        public decimal? GlHolding { get; set; }
        public string UnitCostOnRecurringInv { get; set; }
        public string IncomeTypeDefault { get; set; }
        public string ForeignFlag { get; set; }
        public string ReverseInventory { get; set; }
        public string ProtectPreviousCertRet { get; set; }
        public string ProtectGlJc { get; set; }
        public string CustomerHeldEntry { get; set; }
        public string CashInvFormat { get; set; }
        public string DefaultInvDtEntry { get; set; }
        public string AutoPostFlag { get; set; }
        public string InvoiceListDetailFlag { get; set; }
        public string InvoiceListDetailType { get; set; }
        public string InvoiceListGlsummFlag { get; set; }
        public string InvoiceListJobsummFlag { get; set; }
        public string InvoiceListEqsummFlag { get; set; }
        public string InvoiceListDetailSort { get; set; }
        public string TaxInPercCompPrevInvAmt { get; set; }
        public string SetBackNextInvNo { get; set; }
        public string SetBackNextInvId { get; set; }
        public string EnableAiaQuickRollback { get; set; }
        public string ShowNotesOnAging { get; set; }
        public string AiaQuickRollbackDate { get; set; }
        public DateTime? ProposalStartDate { get; set; }
        public DateTime? ProposalEndDate { get; set; }
        public string ProposalDateFlag { get; set; }
        public DateTime? AiaJobFilterDate { get; set; }
        public string DefaultToCustomerRecord { get; set; }
        public int? DefaultDiscountDiv1 { get; set; }
        public int? DefaultDiscountDiv2 { get; set; }
        public int? DefaultDiscountDiv3 { get; set; }
        public int? DefaultDiscountDiv4 { get; set; }
        public string DefaultDiscountSeq { get; set; }
        public string EnableGlAccounts { get; set; }
        public string OverrideUnitCost { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts Accounts1 { get; set; }
        public Accounts Accounts10 { get; set; }
        public Accounts Accounts11 { get; set; }
        public Accounts Accounts12 { get; set; }
        public Accounts Accounts13 { get; set; }
        public Accounts Accounts14 { get; set; }
        public Accounts Accounts2 { get; set; }
        public Accounts Accounts3 { get; set; }
        public Accounts Accounts4 { get; set; }
        public Accounts Accounts5 { get; set; }
        public Accounts Accounts6 { get; set; }
        public Accounts Accounts7 { get; set; }
        public Accounts Accounts8 { get; set; }
        public Accounts Accounts9 { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public CostClasses CostClasses { get; set; }
        public CostClasses CostClasses1 { get; set; }
        public CostClasses CostClasses2 { get; set; }
        public CostClasses CostClassesNavigation { get; set; }
        public CostCodes CostCodes { get; set; }
        public CostCodes CostCodes1 { get; set; }
        public CostCodes CostCodes2 { get; set; }
        public CostCodes CostCodes3 { get; set; }
        public CostCodes CostCodesNavigation { get; set; }
        public Jobs Jobs { get; set; }
        public Jobs JobsNavigation { get; set; }
        public Phases Phases { get; set; }
        public Phases Phases1 { get; set; }
        public Phases Phases2 { get; set; }
        public Phases Phases3 { get; set; }
        public Phases PhasesNavigation { get; set; }
        public PriceLevels PriceLevels { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public Terms Terms1 { get; set; }
        public Terms TermsNavigation { get; set; }
        public Warehouses Warehouses { get; set; }
    }
}
