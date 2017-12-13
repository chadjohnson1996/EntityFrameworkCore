using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class QtyPaidJournalD
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int SequenceNo { get; set; }
        public int EstTrxNo { get; set; }
        public string BidNo { get; set; }
        public string InvoiceNo { get; set; }
        public string PostedFlag { get; set; }
        public string Description { get; set; }
        public decimal BilledQty { get; set; }
        public decimal PrevPaidQty { get; set; }
        public decimal CurrentQty { get; set; }
        public decimal CurrentAmount { get; set; }
        public decimal RetainageAmount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public decimal RetainagePercent { get; set; }
        public decimal BilledPercent { get; set; }
        public decimal CurrentPercent { get; set; }
        public decimal PrevPaidPercent { get; set; }
        public string BidId { get; set; }
        public string CompanyId { get; set; }
        public string EstTrxId { get; set; }
        public string InvoiceId { get; set; }
        public string SequenceId { get; set; }
        public string TransactionId { get; set; }

        public BidD BidD { get; set; }
        public BidH BidH { get; set; }
    }
}
