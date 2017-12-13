using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ArCash
    {
        public ArCash()
        {
            ArCashDistribution = new HashSet<ArCashDistribution>();
            ArCashInvoice = new HashSet<ArCashInvoice>();
            ArHistory = new HashSet<ArHistory>();
            ArInvoice = new HashSet<ArInvoice>();
        }

        public int CompanyNo { get; set; }
        public int CashReceiptNo { get; set; }
        public string CustomerNo { get; set; }
        public string PostedFlag { get; set; }
        public string Description { get; set; }
        public DateTime ReceiptDate { get; set; }
        public DateTime? PostDate { get; set; }
        public string CheckNo { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? RetainageAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? ArAmount { get; set; }
        public decimal? GlCash { get; set; }
        public string CashReceiptType { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CashReceiptId { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string CustomerId { get; set; }
        public string PostToHoldingAccount { get; set; }
        public int? ArInvoiceAuditNo { get; set; }
        public string ArInvoiceAuditId { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }
        public string BadDebt { get; set; }
        public string Reversal { get; set; }
        public int? OriginalCashReceiptNo { get; set; }
        public string OriginalCashReceiptId { get; set; }
        public string CashReceiptSource { get; set; }
        public string CashFlag { get; set; }

        public Customers C { get; set; }
        public ICollection<ArCashDistribution> ArCashDistribution { get; set; }
        public ICollection<ArCashInvoice> ArCashInvoice { get; set; }
        public ICollection<ArHistory> ArHistory { get; set; }
        public ICollection<ArInvoice> ArInvoice { get; set; }
    }
}
