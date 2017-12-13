using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UnionSplitDf
    {
        public int CompanyNo { get; set; }
        public string UnionNo { get; set; }
        public string SplitCode { get; set; }
        public string DeductionFringeNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeductionFringeId { get; set; }
        public string UnionId { get; set; }

        public UnionSplit UnionSplit { get; set; }
    }
}
