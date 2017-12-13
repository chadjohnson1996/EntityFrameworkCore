using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobPhases
    {
        public JobPhases()
        {
            DcRfcPhases = new HashSet<DcRfcPhases>();
            JobChgPhases = new HashSet<JobChgPhases>();
            JobCostcodes = new HashSet<JobCostcodes>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string Description { get; set; }
        public string CostCodeMethod { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public string PhaseStatus { get; set; }

        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
        public JobSchedules JobSchedules { get; set; }
        public ICollection<DcRfcPhases> DcRfcPhases { get; set; }
        public ICollection<JobChgPhases> JobChgPhases { get; set; }
        public ICollection<JobCostcodes> JobCostcodes { get; set; }
    }
}
