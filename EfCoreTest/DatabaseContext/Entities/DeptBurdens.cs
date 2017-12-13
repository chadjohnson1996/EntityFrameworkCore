using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DeptBurdens
    {
        public int CompanyNo { get; set; }
        public string DeptNo { get; set; }
        public int BurdenNo { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? GlExpense { get; set; }
        public decimal? GlPayable { get; set; }
        public decimal? Limit { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BurdenId { get; set; }
        public string CompanyId { get; set; }
        public string DeptId { get; set; }
        public string Excluded { get; set; }

        public Departments Departments { get; set; }
    }
}
