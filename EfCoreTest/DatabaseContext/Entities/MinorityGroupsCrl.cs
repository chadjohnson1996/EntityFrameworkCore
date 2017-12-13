using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class MinorityGroupsCrl
    {
        public int CompanyNo { get; set; }
        public string MinorityGroupNo { get; set; }
        public string Format { get; set; }
        public string CraftCode { get; set; }
        public string LaborCode { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string MinorityGroupId { get; set; }

        public MinorityGroups MinorityGroups { get; set; }
    }
}
