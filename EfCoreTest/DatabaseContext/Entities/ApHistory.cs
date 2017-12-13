using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApHistory
    {
        public int CompanyNo { get; set; }
        public int VoucherNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public int LineNo { get; set; }
        public string HistoryType { get; set; }
        public int? AdjustVoucherNo { get; set; }
        public decimal? AdjustInvoiceAmount { get; set; }
        public decimal? AdjustTaxBase { get; set; }
        public decimal? AdjustDiscountBase { get; set; }
        public decimal? AdjustDiscountAmount { get; set; }
        public decimal? AdjustRetainageAmount { get; set; }
        public int? CheckNo { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? RetainageAmount { get; set; }
        public decimal? GlCash { get; set; }
        public string CheckType { get; set; }
        public int RowUniqueId { get; set; }
        public string AdjustVoucherId { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string VoucherId { get; set; }
        public decimal AdjustSalesTaxAmount { get; set; }
        public decimal AdjustUseTaxAmount { get; set; }

        public ApInvoiceH ApInvoiceH { get; set; }
    }
}
