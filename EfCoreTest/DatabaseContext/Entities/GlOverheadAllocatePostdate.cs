using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class GlOverheadAllocatePostdate
    {
        public int CompanyNo { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime? PostedStartDate { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
    }
}
