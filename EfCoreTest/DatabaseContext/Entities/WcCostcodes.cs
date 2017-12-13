using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class WcCostcodes
    {
        public int CompanyNo { get; set; }
        public string WcState { get; set; }
        public string CostCodeNo { get; set; }
        public string Description { get; set; }
        public string WcClassNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string WcClassId { get; set; }

        public CostCodes Co { get; set; }
        public WcClasses WcClasses { get; set; }
    }
}
