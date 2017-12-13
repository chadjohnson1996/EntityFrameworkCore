using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DeptEarnCodes
    {
        public int CompanyNo { get; set; }
        public string DeptNo { get; set; }
        public string EarnTypeNo { get; set; }
        public decimal? GlExpense { get; set; }
        public decimal? GlFringe { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeptId { get; set; }
        public string EarnTypeId { get; set; }

        public Departments Departments { get; set; }
    }
}
