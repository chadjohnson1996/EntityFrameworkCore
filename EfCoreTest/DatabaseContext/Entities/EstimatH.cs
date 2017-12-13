using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EstimatH
    {
        public EstimatH()
        {
            EstimatD = new HashSet<EstimatD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string BidNo { get; set; }
        public string EstimateNo { get; set; }
        public string PostedFlag { get; set; }
        public DateTime EstimateDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? QtyCompleteAsOf { get; set; }
        public string TransactionType { get; set; }
        public int? OriginalTransactionNo { get; set; }
        public int? RollbackTransactionNo { get; set; }
        public string InvoiceSource { get; set; }
        public string InvoiceNo { get; set; }
        public string TermsNo { get; set; }
        public DateTime? DiscountDate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public DateTime? EstimatePeriod { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? EstimatePeriodEnd { get; set; }
        public decimal ReleasedRetainageAmount { get; set; }
        public string BidId { get; set; }
        public string CompanyId { get; set; }
        public string EstimateId { get; set; }
        public string InvoiceId { get; set; }
        public string OriginalTransactionId { get; set; }
        public string RollbackTransactionId { get; set; }
        public string TermsId { get; set; }
        public string TransactionId { get; set; }
        public int? MostRecentEstimate { get; set; }

        public BidH BidH { get; set; }
        public Terms Terms { get; set; }
        public ICollection<EstimatD> EstimatD { get; set; }
    }
}
