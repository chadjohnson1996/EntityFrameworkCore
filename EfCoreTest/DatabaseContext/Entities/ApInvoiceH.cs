using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApInvoiceH
    {
        public ApInvoiceH()
        {
            ApHistory = new HashSet<ApHistory>();
            ApInvoiceD = new HashSet<ApInvoiceD>();
            ApInvoiceFuelD = new HashSet<ApInvoiceFuelD>();
            ApInvoiceItemD = new HashSet<ApInvoiceItemD>();
            ApInvoiceSubtierVendors = new HashSet<ApInvoiceSubtierVendors>();
            InventoryActivityH = new HashSet<InventoryActivityH>();
            InventoryReceiptsH = new HashSet<InventoryReceiptsH>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
        }

        public int CompanyNo { get; set; }
        public int VoucherNo { get; set; }
        public string PostedFlag { get; set; }
        public string VendorNo { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime? DiscountDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? PostDate { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string InvoiceNo { get; set; }
        public string JobNo { get; set; }
        public string TaxNo { get; set; }
        public string PayClassNo { get; set; }
        public int? CheckNo { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? TaxBase { get; set; }
        public decimal? DiscountBase { get; set; }
        public decimal? RetainageAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? CheckAmount { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? RetainagePercent { get; set; }
        public decimal GlAp { get; set; }
        public decimal? GlDiscount { get; set; }
        public decimal? GlRet { get; set; }
        public decimal? GlCash { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public int? OriginalVoucherNo { get; set; }
        public decimal? OriginalInvoiceAmount { get; set; }
        public decimal? OriginalTaxBase { get; set; }
        public decimal? OriginalDiscountBase { get; set; }
        public decimal? OriginalDiscountAmount { get; set; }
        public decimal? OriginalRetainageAmount { get; set; }
        public decimal? AdjustInvoiceAmount { get; set; }
        public decimal? AdjustTaxBase { get; set; }
        public decimal? AdjustDiscountBase { get; set; }
        public decimal? AdjustDiscountAmount { get; set; }
        public decimal? AdjustRetainageAmount { get; set; }
        public int? NextLineNo { get; set; }
        public string VoucherSource { get; set; }
        public string VoucherType { get; set; }
        public string PayStatus { get; set; }
        public string ClosedFlag { get; set; }
        public string UseTaxAdded { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string InternalNote { get; set; }
        public int? OriginalAdjustmentNo { get; set; }
        public string TermsNo { get; set; }
        public string PoSubNo { get; set; }
        public string ChangeOrderNo { get; set; }
        public string ReportingClassNo { get; set; }
        public string ChangeOrderId { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string InvoiceId { get; set; }
        public string JobId { get; set; }
        public string NextLineId { get; set; }
        public string OriginalAdjustmentId { get; set; }
        public string OriginalVoucherId { get; set; }
        public string PayClassId { get; set; }
        public string PoSubId { get; set; }
        public string ReportingClassId { get; set; }
        public string TaxId { get; set; }
        public string TermsId { get; set; }
        public string VendorId { get; set; }
        public string VoucherId { get; set; }
        public string UseRetainage { get; set; }
        public string LienWaiverFlag { get; set; }
        public string WaiverDescription { get; set; }
        public string WaiverTradeWork { get; set; }
        public string WaiverTitle { get; set; }
        public string WaiverSignatureName { get; set; }
        public string LinkInventoryReceipt { get; set; }
        public decimal GoodsServiceAmount { get; set; }
        public decimal InventoryAmount { get; set; }
        public decimal OtherAmount { get; set; }
        public decimal SalesTaxAmount { get; set; }
        public decimal UseTaxAmount { get; set; }
        public string TaxType { get; set; }
        public string VerifyTaxToPo { get; set; }
        public decimal OriginalGoodsServiceAmount { get; set; }
        public decimal OriginalInventoryAmount { get; set; }
        public decimal OriginalOtherAmount { get; set; }
        public decimal OriginalSalesTaxAmount { get; set; }
        public decimal OriginalUseTaxAmount { get; set; }
        public decimal AdjustGoodsServiceAmount { get; set; }
        public decimal AdjustInventoryAmount { get; set; }
        public decimal AdjustOtherAmount { get; set; }
        public decimal AdjustSalesTaxAmount { get; set; }
        public decimal AdjustUseTaxAmount { get; set; }
        public string SalesTaxAmtChanged { get; set; }
        public string PostalCodeFlag { get; set; }
        public string ForeignPostalCode { get; set; }
        public string Reversal { get; set; }
        public string UseTaxSelection { get; set; }
        public string AutoSelect { get; set; }
        public string AutoPost { get; set; }
        public int? PrAuditNumber { get; set; }
        public string RecurringFlag { get; set; }
        public int? RecurringVoucherNo { get; set; }
        public string RecurringFrequency { get; set; }
        public DateTime? RecurringStartDate { get; set; }
        public string RecurringEndFlag { get; set; }
        public int RecurringOccurrences { get; set; }
        public DateTime? RecurringEndDate { get; set; }
        public string PrintCheckNow { get; set; }
        public string RecurringVoucherId { get; set; }
        public string Provider { get; set; }
        public string RecurringGenerateInvoice { get; set; }
        public string ScannedInvoiceImage { get; set; }
        public decimal PpdDiscountTaken { get; set; }
        public decimal PpdChkAmtBfDiscTkn { get; set; }
        public string RoutingStatus { get; set; }
        public string PrepaidCreditCardFlag { get; set; }
        public string FullInvoiceNo { get; set; }
        public string FullInvoiceId { get; set; }
        public string EasyCheck { get; set; }
        public string CheckMemo { get; set; }
        public string VoucherPaymentType { get; set; }
        public decimal? DefaultCost { get; set; }
        public string RecurringGenerateFlag { get; set; }
        public DateTime? OriginalInvDate { get; set; }
        public string UseAltReturnAddress { get; set; }
        public string AltReturnAddress1 { get; set; }
        public string AltReturnAddress2 { get; set; }
        public string AltReturnAddress3 { get; set; }
        public string AltReturnAddress4 { get; set; }
        public string AltReturnAddress5 { get; set; }

        public ApPayClasses ApPayClasses { get; set; }
        public Jobs Jobs { get; set; }
        public PoSubChangeH PoSubChangeH { get; set; }
        public PoSubH PoSubH { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public Terms Terms { get; set; }
        public Vendors Vendors { get; set; }
        public ICollection<ApHistory> ApHistory { get; set; }
        public ICollection<ApInvoiceD> ApInvoiceD { get; set; }
        public ICollection<ApInvoiceFuelD> ApInvoiceFuelD { get; set; }
        public ICollection<ApInvoiceItemD> ApInvoiceItemD { get; set; }
        public ICollection<ApInvoiceSubtierVendors> ApInvoiceSubtierVendors { get; set; }
        public ICollection<InventoryActivityH> InventoryActivityH { get; set; }
        public ICollection<InventoryReceiptsH> InventoryReceiptsH { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
    }
}
