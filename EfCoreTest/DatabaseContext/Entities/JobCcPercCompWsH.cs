using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobCcPercCompWsH
    {
        public JobCcPercCompWsH()
        {
            JobCcPercCompWsD = new HashSet<JobCcPercCompWsD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string JobNo { get; set; }
        public DateTime DateBooked { get; set; }
        public string Description { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BaseProjectedCostOn { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public string TransactionId { get; set; }

        public Jobs Jobs { get; set; }
        public ICollection<JobCcPercCompWsD> JobCcPercCompWsD { get; set; }
    }
}
