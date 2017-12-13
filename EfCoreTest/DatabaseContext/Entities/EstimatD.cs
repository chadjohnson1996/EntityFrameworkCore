using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EstimatD
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int SequenceNo { get; set; }
        public string BidNo { get; set; }
        public string EstimateNo { get; set; }
        public string PostedFlag { get; set; }
        public decimal Quantity { get; set; }
        public decimal Percentage { get; set; }
        public decimal Amount { get; set; }
        public string UseRetainage { get; set; }
        public decimal RetainagePercent { get; set; }
        public decimal Retainage { get; set; }
        public decimal UnbilledQuantity { get; set; }
        public decimal UnbilledPercent { get; set; }
        public decimal PrevBilledQuantity { get; set; }
        public decimal PrevBilledPercent { get; set; }
        public decimal PrevBilledAmount { get; set; }
        public decimal PrevBilledRetainage { get; set; }
        public decimal OriginalQuantity { get; set; }
        public decimal OriginalPercent { get; set; }
        public decimal OriginalAmount { get; set; }
        public decimal OriginalRetainage { get; set; }
        public decimal AdjustQuantity { get; set; }
        public decimal AdjustPercent { get; set; }
        public decimal AdjustAmount { get; set; }
        public decimal AdjustRetainage { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BidId { get; set; }
        public string CompanyId { get; set; }
        public string EstimateId { get; set; }
        public string SequenceId { get; set; }
        public string TransactionId { get; set; }
        public decimal StoredMatAmount { get; set; }
        public string StoredMatUseRet { get; set; }
        public decimal StoredMatRetPerc { get; set; }
        public decimal StoredMatRetainage { get; set; }
        public decimal OriginalStoredMatAmt { get; set; }
        public decimal OriginalStoredMatRet { get; set; }
        public decimal AdjustStoredMatAmt { get; set; }
        public decimal AdjustStoredMatRet { get; set; }
        public string ReleaseRetainageFlag { get; set; }
        public decimal PrevRetainagePercent { get; set; }
        public decimal ReleasedRetainageAmt { get; set; }
        public decimal OriginalReleasedRetainageAmt { get; set; }
        public decimal PrevStoredMatRetPerc { get; set; }
        public decimal StoredMatReleasedRetainageAmt { get; set; }
        public decimal PrevBilledMatRetainage { get; set; }
        public decimal PrevStoredMatAmount { get; set; }
        public string ReleaseRetConverted { get; set; }

        public BidD BidD { get; set; }
        public BidH BidH { get; set; }
        public EstimatH EstimatH { get; set; }
    }
}
