using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class GlOverheadAllocatePostjobs
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public decimal AllocationAmount { get; set; }
        public DateTime LastPostDate { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
    }
}
