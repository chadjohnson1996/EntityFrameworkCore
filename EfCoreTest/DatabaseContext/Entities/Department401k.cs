using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Department401k
    {
        public int CompanyNo { get; set; }
        public string DeptNo { get; set; }
        public string P401kDeductionNo { get; set; }
        public decimal? GlExpense { get; set; }
        public decimal? GlCredit { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeptId { get; set; }
        public string P401kDeductionId { get; set; }

        public Departments Departments { get; set; }
    }
}
