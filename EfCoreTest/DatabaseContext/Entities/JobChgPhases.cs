using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobChgPhases
    {
        public JobChgPhases()
        {
            JobChgCostCodes = new HashSet<JobChgCostCodes>();
        }

        public int CompanyNo { get; set; }
        public string ChangeOrderNo { get; set; }
        public int ChangeOrderSeq { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ChangeOrderId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }

        public JobChg JobChg { get; set; }
        public JobPhases JobPhases { get; set; }
        public ICollection<JobChgCostCodes> JobChgCostCodes { get; set; }
    }
}
