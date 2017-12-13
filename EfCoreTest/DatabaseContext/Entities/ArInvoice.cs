using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ArInvoice
    {
        public ArInvoice()
        {
            ArCashInvoice = new HashSet<ArCashInvoice>();
            ArHistory = new HashSet<ArHistory>();
            ArInvoiceEq = new HashSet<ArInvoiceEq>();
            ArInvoiceGl = new HashSet<ArInvoiceGl>();
            ArInvoiceJc = new HashSet<ArInvoiceJc>();
            InventoryActivityH = new HashSet<InventoryActivityH>();
        }

        public int CompanyNo { get; set; }
        public string InvoiceSource { get; set; }
        public string InvoiceNo { get; set; }
        public string PostedFlag { get; set; }
        public string CustomerNo { get; set; }
        public string Description { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DiscountDate { get; set; }
        public DateTime? PostDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string EstimateNo { get; set; }
        public string JobNo { get; set; }
        public string TaxNo { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? AmountDue { get; set; }
        public decimal? RetainageAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? TaxBase { get; set; }
        public decimal? UseTaxBase { get; set; }
        public decimal? OriginalInvoiceAmount { get; set; }
        public decimal? OriginalTaxAmount { get; set; }
        public decimal? OriginalAmountDue { get; set; }
        public decimal? OriginalRetainageAmount { get; set; }
        public decimal? OriginalDiscountAmount { get; set; }
        public decimal? OriginalTaxBase { get; set; }
        public decimal? AdjustTaxAmount { get; set; }
        public decimal? AdjustAmountDue { get; set; }
        public decimal? AdjustRetainageAmount { get; set; }
        public decimal? AdjustDiscountAmount { get; set; }
        public decimal? AdjustTaxBase { get; set; }
        public decimal? AdjustUseTaxBase { get; set; }
        public decimal? GlAr { get; set; }
        public decimal? GlRetainage { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? RetainagePercent { get; set; }
        public decimal? ReleaseRetainagePercent { get; set; }
        public decimal? ReleaseRetainageAmount { get; set; }
        public string HiddenSalesTax { get; set; }
        public string AiaSectionNo { get; set; }
        public string ClosedFlag { get; set; }
        public string HoldFlag { get; set; }
        public string IncomeTypeNo { get; set; }
        public string ServiceCharge { get; set; }
        public string InvoiceType { get; set; }
        public string OriginalInvoiceNo { get; set; }
        public string PurgeReversal { get; set; }
        public int? CashReceiptNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public decimal? OriginalUseTaxBase { get; set; }
        public decimal? AdjustInvoiceAmount { get; set; }
        public string OriginalAdjustmentNo { get; set; }
        public string PrintableInvoice { get; set; }
        public int? DesignNo { get; set; }
        public string TermsNo { get; set; }
        public decimal? GlTax { get; set; }
        public string Reversal { get; set; }
        public string UseRetainage { get; set; }
        public decimal? OriginalRetainagePercent { get; set; }
        public decimal OriginalReleaseRetainageAmount { get; set; }
        public decimal AdjustReleaseRetainageAmount { get; set; }
        public string Provider { get; set; }
        public string AiaSectionId { get; set; }
        public string CashReceiptId { get; set; }
        public string CompanyId { get; set; }
        public string CustomerId { get; set; }
        public string DesignId { get; set; }
        public string EstimateId { get; set; }
        public string IncomeTypeId { get; set; }
        public string InvoiceId { get; set; }
        public string JobId { get; set; }
        public string OriginalAdjustmentId { get; set; }
        public string OriginalInvoiceId { get; set; }
        public string TaxId { get; set; }
        public string TermsId { get; set; }
        public string TmReversalMode { get; set; }
        public string UpdateInventory { get; set; }
        public string PrintableInvoiceEntry { get; set; }
        public string IncludeInPercentComplete { get; set; }
        public string ServiceChargeEligible { get; set; }
        public string ServiceChargeBasedOn { get; set; }
        public string ProposalFlag { get; set; }
        public string ProposalStatus { get; set; }
        public string FromInvoiceNo { get; set; }
        public string FromInvoiceId { get; set; }
        public string RecurringFlag { get; set; }
        public string RecurringInvoiceNo { get; set; }
        public string RecurringFrequency { get; set; }
        public DateTime? RecurringStartDate { get; set; }
        public string RecurringEndFlag { get; set; }
        public int RecurringOccurrences { get; set; }
        public DateTime? RecurringEndDate { get; set; }
        public string FromInvoiceSource { get; set; }
        public string RecurringGenerateInvoice { get; set; }
        public string RecurringInvoiceId { get; set; }
        public string AiaInvoice { get; set; }
        public string UpBidNo { get; set; }
        public string UpBidId { get; set; }
        public string ShipToNo { get; set; }
        public string ShipToId { get; set; }
        public decimal PaymentAmount { get; set; }
        public string PaymentType { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string CheckNumber { get; set; }
        public string SbUniqueIdn { get; set; }
        public decimal DepositAmount { get; set; }
        public string DepositType { get; set; }
        public DateTime? DepositDate { get; set; }
        public string DepositCheckNumber { get; set; }
        public decimal? PaymentGl { get; set; }
        public decimal? DepositGl { get; set; }
        public string PaymentToHoldingAccount { get; set; }
        public string DepositToHoldingAccount { get; set; }
        public decimal? PaymentDiscount { get; set; }
        public string TaxByEffdateFlag { get; set; }
        public decimal? StateTaxPercent { get; set; }
        public decimal? StateTaxableLimit { get; set; }
        public decimal? StateTaxAmount { get; set; }
        public decimal? LocalTaxPercent { get; set; }
        public decimal? LocalTaxableLimit { get; set; }
        public decimal? LocalTaxAmount { get; set; }
        public decimal? OtherTaxPercent { get; set; }
        public decimal? OtherTaxableLimit { get; set; }
        public decimal? OtherTaxAmount { get; set; }
        public string PaymentDescription { get; set; }
        public string SdContractString { get; set; }
        public int? SdRenewalNum { get; set; }
        public int? SdBillNum { get; set; }

        public ArCash C { get; set; }
        public Customers CNavigation { get; set; }
        public DsgDesigns DesignNoNavigation { get; set; }
        public IncomeTypes IncomeTypes { get; set; }
        public Jobs Jobs { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public Terms Terms { get; set; }
        public ArInvoiceFrmH ArInvoiceFrmH { get; set; }
        public ICollection<ArCashInvoice> ArCashInvoice { get; set; }
        public ICollection<ArHistory> ArHistory { get; set; }
        public ICollection<ArInvoiceEq> ArInvoiceEq { get; set; }
        public ICollection<ArInvoiceGl> ArInvoiceGl { get; set; }
        public ICollection<ArInvoiceJc> ArInvoiceJc { get; set; }
        public ICollection<InventoryActivityH> InventoryActivityH { get; set; }
    }
}
