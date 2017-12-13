using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class BurdenTypes
    {
        public BurdenTypes()
        {
            JobHistoryPrBrdDtl = new HashSet<JobHistoryPrBrdDtl>();
        }

        public string BurdenType { get; set; }
        public int LineNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string LineId { get; set; }

        public ICollection<JobHistoryPrBrdDtl> JobHistoryPrBrdDtl { get; set; }
    }
}
