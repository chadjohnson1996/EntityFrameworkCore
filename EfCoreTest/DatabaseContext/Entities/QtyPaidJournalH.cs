using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class QtyPaidJournalH
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string TransactionType { get; set; }
        public string BidNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public int CashReceiptNo { get; set; }
        public string InvoiceNo { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public string MethodForPayQty { get; set; }
        public decimal CurrentAmtPaid { get; set; }
        public decimal AdjAmount { get; set; }
        public string Comment { get; set; }
        public int? OriginalTrxNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public decimal RetainageAmount { get; set; }
        public string BidId { get; set; }
        public string CashReceiptId { get; set; }
        public string CompanyId { get; set; }
        public string InvoiceId { get; set; }
        public string OriginalTrxId { get; set; }
        public string TransactionId { get; set; }
        public decimal StoredMatPaid { get; set; }
        public decimal PrevBilledStoredMat { get; set; }

        public BidH BidH { get; set; }
    }
}
