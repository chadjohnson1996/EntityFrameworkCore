using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class P401k
    {
        public P401k()
        {
            Emp401k = new HashSet<Emp401k>();
            P401kLevels = new HashSet<P401kLevels>();
        }

        public int CompanyNo { get; set; }
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
        public string P401kDeductionId { get; set; }
        public decimal PerPayAmount { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string ReportOnW2Box12 { get; set; }
        public string W2Box12CodeNo { get; set; }
        public string W2Box12CodeId { get; set; }
        public string ReportOnW2Box14 { get; set; }
        public string W2Box14Code { get; set; }

        public Deductions Deductions { get; set; }
        public ICollection<Emp401k> Emp401k { get; set; }
        public ICollection<P401kLevels> P401kLevels { get; set; }
    }
}
