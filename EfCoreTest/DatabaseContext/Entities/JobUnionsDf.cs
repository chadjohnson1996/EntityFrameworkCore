using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobUnionsDf
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string UnionNo { get; set; }
        public string DeductionNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeductionId { get; set; }
        public string JobId { get; set; }
        public string UnionId { get; set; }

        public JobUnions JobUnions { get; set; }
    }
}
