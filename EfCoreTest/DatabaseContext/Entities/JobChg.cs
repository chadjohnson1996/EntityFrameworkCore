using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobChg
    {
        public JobChg()
        {
            AiaItem = new HashSet<AiaItem>();
            JobChgCorrespondences = new HashSet<JobChgCorrespondences>();
            JobChgDcRfcs = new HashSet<JobChgDcRfcs>();
            JobChgPhases = new HashSet<JobChgPhases>();
            JobChgPrintable = new HashSet<JobChgPrintable>();
            JobChgRfcs = new HashSet<JobChgRfcs>();
            Rfcs = new HashSet<Rfcs>();
        }

        public int CompanyNo { get; set; }
        public string ChangeOrderNo { get; set; }
        public int ChangeOrderSeq { get; set; }
        public string JobNo { get; set; }
        public DateTime DateBooked { get; set; }
        public string Status { get; set; }
        public string OwnerCoNo { get; set; }
        public decimal? TotIncomeAdj { get; set; }
        public decimal? TotCostAdj { get; set; }
        public decimal? TotQuantityAdj { get; set; }
        public decimal? TotUnitAdj { get; set; }
        public string Comments { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string PrintableChgOrd { get; set; }
        public string PrintedFlag { get; set; }
        public string ChangeOrderId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public string OwnerCoId { get; set; }
        public string IncludeInPercentComplete { get; set; }
        public string UpdatePrintableType { get; set; }
        public string UpdatePrintableFlag { get; set; }
        public string PrintDetailFlag { get; set; }
        public int InternalBatchNumber { get; set; }

        public Jobs Jobs { get; set; }
        public ICollection<AiaItem> AiaItem { get; set; }
        public ICollection<JobChgCorrespondences> JobChgCorrespondences { get; set; }
        public ICollection<JobChgDcRfcs> JobChgDcRfcs { get; set; }
        public ICollection<JobChgPhases> JobChgPhases { get; set; }
        public ICollection<JobChgPrintable> JobChgPrintable { get; set; }
        public ICollection<JobChgRfcs> JobChgRfcs { get; set; }
        public ICollection<Rfcs> Rfcs { get; set; }
    }
}
