using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ArTaxReceived
    {
        public int CompanyNo { get; set; }
        public string InvoiceSource { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public int LineNo { get; set; }
        public string HistoryType { get; set; }
        public string AdjustInvoiceNo { get; set; }
        public int? CashReceiptNo { get; set; }
        public string CheckNo { get; set; }
        public string TaxNo { get; set; }
        public decimal TaxReceived { get; set; }
        public string ReleaseInvoiceNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AdjustInvoiceId { get; set; }
        public string CashReceiptId { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string InvoiceId { get; set; }
        public string LineId { get; set; }
        public string ReleaseInvoiceId { get; set; }
        public string TaxId { get; set; }
    }
}
