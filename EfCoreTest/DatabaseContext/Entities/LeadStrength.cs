using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class LeadStrength
    {
        public string RecordStatus { get; set; }
        public int? CompanyNo { get; set; }
        public string LeadStrengthNo { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string Description { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string LeadStrengthId { get; set; }
    }
}
