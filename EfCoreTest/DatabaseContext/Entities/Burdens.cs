using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Burdens
    {
        public int CompanyNo { get; set; }
        public int BurdenNo { get; set; }
        public string Description { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? Limit { get; set; }
        public decimal? GlExpense { get; set; }
        public decimal? GlPayable { get; set; }
        public string BurdenType { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BurdenId { get; set; }
        public string CompanyId { get; set; }
        public string LimitType { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string IncludeInFringeBenefitGroup { get; set; }
    }
}
