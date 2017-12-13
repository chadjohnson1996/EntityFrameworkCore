using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Emp401k
    {
        public Emp401k()
        {
            Emp401kLevels = new HashSet<Emp401kLevels>();
        }

        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string P401kDeductionNo { get; set; }
        public decimal? WagePercent { get; set; }
        public decimal? MatchingLimit { get; set; }
        public decimal? GlExpense { get; set; }
        public decimal? GlCredit { get; set; }
        public decimal? EarningsLimit { get; set; }
        public string WagePercentType { get; set; }
        public string LesserOfFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string P401kDeductionId { get; set; }
        public decimal PerPayAmount { get; set; }
        public string PlanType { get; set; }

        public Employees Employees { get; set; }
        public P401k P401k { get; set; }
        public ICollection<Emp401kLevels> Emp401kLevels { get; set; }
    }
}
