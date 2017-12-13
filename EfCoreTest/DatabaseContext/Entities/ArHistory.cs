using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ArHistory
    {
        public int CompanyNo { get; set; }
        public string InvoiceSource { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public int LineNo { get; set; }
        public string HistoryType { get; set; }
        public string AdjustInvoiceNo { get; set; }
        public decimal? AdjustInvoiceAmount { get; set; }
        public decimal? AdjustTaxAmount { get; set; }
        public decimal? AdjustAmountDue { get; set; }
        public decimal? AdjustRetainageAmount { get; set; }
        public decimal? AdjustDiscountAmount { get; set; }
        public decimal? AdjustTaxBase { get; set; }
        public decimal? AdjustUseTaxBase { get; set; }
        public int? CashReceiptNo { get; set; }
        public string CheckNo { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? RetainageAmount { get; set; }
        public string TaxNo { get; set; }
        public decimal? TaxReceived { get; set; }
        public string RecordStatus { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string RowModifiedBy { get; set; }
        public int RowUniqueId { get; set; }
        public decimal AdjustReleaseRetainageAmount { get; set; }
        public string AdjustInvoiceId { get; set; }
        public string CashReceiptId { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string InvoiceId { get; set; }
        public string LineId { get; set; }
        public string TaxId { get; set; }
        public string PreviouslyReceivedDeposit { get; set; }

        public ArInvoice ArInvoice { get; set; }
        public ArCash C { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
    }
}
