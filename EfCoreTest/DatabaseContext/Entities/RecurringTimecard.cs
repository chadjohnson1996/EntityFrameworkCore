using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RecurringTimecard
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public int SequenceNo { get; set; }
        public int LineNo { get; set; }
        public string TimecardType { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Amount { get; set; }
        public string EarnTypeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public string DeptNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string DeptId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PayPeriodId { get; set; }
        public string PhaseId { get; set; }
        public string SequenceId { get; set; }

        public CostCodes Co { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
    }
}
