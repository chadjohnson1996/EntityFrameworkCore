using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobUnions
    {
        public JobUnions()
        {
            JobUnionsDf = new HashSet<JobUnionsDf>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string OldUnion { get; set; }
        public string NewUnion { get; set; }
        public string DeductionFringeFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }

        public Jobs Jobs { get; set; }
        public Unions Unions { get; set; }
        public Unions UnionsNavigation { get; set; }
        public ICollection<JobUnionsDf> JobUnionsDf { get; set; }
    }
}
