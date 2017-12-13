using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlScheduler
    {
        public int CompanyNo { get; set; }
        public string JobUserSpecific { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ShowObsoleteResources { get; set; }
        public string IncludeBidTitlesTotals { get; set; }
        public string EnableUnitPriceBilling { get; set; }
    }
}
