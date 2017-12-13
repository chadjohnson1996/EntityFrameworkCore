using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobPercCompWsD
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string JobNo { get; set; }
        public DateTime DateBooked { get; set; }
        public decimal EstimatedCost { get; set; }
        public decimal CostsToDate { get; set; }
        public decimal CalcPercentComp { get; set; }
        public decimal PreviousPercentComp { get; set; }
        public decimal PercentComplete { get; set; }
        public decimal PeriodPercentComplete { get; set; }
        public decimal ProjectedCost { get; set; }
        public string BaseProjectedCostOn { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string TransactionId { get; set; }

        public JobPercCompWsH JobPercCompWsH { get; set; }
        public Jobs Jobs { get; set; }
    }
}
