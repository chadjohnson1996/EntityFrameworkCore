using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobAreasH
    {
        public JobAreasH()
        {
            JobAreasD = new HashSet<JobAreasD>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }

        public Jobs Jobs { get; set; }
        public ICollection<JobAreasD> JobAreasD { get; set; }
    }
}
