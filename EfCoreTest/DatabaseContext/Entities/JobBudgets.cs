using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobBudgets
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public decimal? OrigEstDollars { get; set; }
        public decimal? OrigEstUnits { get; set; }
        public decimal? OrigEstUnitPrice { get; set; }
        public decimal? AdjEstDollars { get; set; }
        public decimal? AdjEstUnits { get; set; }
        public decimal? AdjEstUnitPrice { get; set; }
        public string Active { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public decimal OrigEstCostToComp { get; set; }

        public CostClasses Co { get; set; }
        public JobCostcodes JobCostcodes { get; set; }
    }
}
