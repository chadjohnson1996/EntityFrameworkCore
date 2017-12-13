using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobCostingSum
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string RecType { get; set; }
        public decimal? CurrentDollars { get; set; }
        public decimal? CurrentUnits { get; set; }
        public decimal? CurrentQuantity { get; set; }
        public decimal? CurrentIncome { get; set; }
        public decimal? CurrentProduction { get; set; }
        public decimal? PreviousDollars { get; set; }
        public decimal? PreviousUnits { get; set; }
        public decimal? PreviousQuantity { get; set; }
        public decimal? PreviousIncome { get; set; }
        public decimal? PreviousProduction { get; set; }
        public decimal? ToDateDollars { get; set; }
        public decimal? ToDateUnits { get; set; }
        public decimal? ToDateQuantity { get; set; }
        public decimal? ToDateIncome { get; set; }
        public decimal? ToDateProduction { get; set; }
        public decimal? EstimatedDollars { get; set; }
        public decimal? EstimatedUnits { get; set; }
        public decimal? EstimatedQuantity { get; set; }
        public decimal? EstimatedIncome { get; set; }
        public decimal? EstimatedProduction { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
    }
}
