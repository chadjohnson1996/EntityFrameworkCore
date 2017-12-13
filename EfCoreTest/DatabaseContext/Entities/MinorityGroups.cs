using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class MinorityGroups
    {
        public MinorityGroups()
        {
            MinorityGroupsCrl = new HashSet<MinorityGroupsCrl>();
        }

        public int CompanyNo { get; set; }
        public string MinorityGroupNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CraftCode { get; set; }
        public string CompanyId { get; set; }
        public string MinorityGroupId { get; set; }
        public string TradeCode { get; set; }

        public ICollection<MinorityGroupsCrl> MinorityGroupsCrl { get; set; }
    }
}
