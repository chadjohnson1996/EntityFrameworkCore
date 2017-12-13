using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobCcQtyCompWsD
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string JobNo { get; set; }
        public DateTime DateBooked { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public decimal EstQty { get; set; }
        public decimal PreviousQty { get; set; }
        public decimal? CalcPercentComp { get; set; }
        public decimal QuantityComp { get; set; }
        public decimal PeriodQuantity { get; set; }
        public decimal EstimatedCost { get; set; }
        public decimal CostToDate { get; set; }
        public decimal ProjectedCost { get; set; }
        public string Description { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }
        public string TransactionId { get; set; }

        public CostCodes Co { get; set; }
        public JobCcQtyCompWsH JobCcQtyCompWsH { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
    }
}
