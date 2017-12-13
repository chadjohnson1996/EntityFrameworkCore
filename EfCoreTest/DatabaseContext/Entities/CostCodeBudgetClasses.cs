using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CostCodeBudgetClasses
    {
        public int CompanyNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }

        public CostClasses Co { get; set; }
    }
}
