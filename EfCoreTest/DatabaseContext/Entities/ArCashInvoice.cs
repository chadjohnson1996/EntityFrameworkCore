using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ArCashInvoice
    {
        public int CompanyNo { get; set; }
        public int CashReceiptNo { get; set; }
        public string InvoiceSource { get; set; }
        public string InvoiceNo { get; set; }
        public int LineNo { get; set; }
        public string PostedFlag { get; set; }
        public decimal? GlAr { get; set; }
        public decimal? GlRetainage { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? RetainageAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? ArAmount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string TakeDiscount { get; set; }
        public string CashReceiptId { get; set; }
        public string CompanyId { get; set; }
        public string InvoiceId { get; set; }
        public string LineId { get; set; }
        public decimal? DiscDivLevel1 { get; set; }
        public decimal? DiscDivLevel2 { get; set; }
        public decimal? DiscDivLevel3 { get; set; }
        public decimal? DiscDivLevel4 { get; set; }

        public ArInvoice ArInvoice { get; set; }
        public ArCash C { get; set; }
    }
}
