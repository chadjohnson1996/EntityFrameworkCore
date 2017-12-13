using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpTcRecurTypes
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public int LineNo { get; set; }
        public string TcRecurTypeNo { get; set; }
        public string EarnTypeNo { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string DeptNo { get; set; }
        public decimal Hours { get; set; }
        public decimal Amount { get; set; }
        public string DisableFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string DeptId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }
        public string TcRecurTypeId { get; set; }

        public CostCodes Co { get; set; }
        public Departments Departments { get; set; }
        public EarnTypes EarnTypes { get; set; }
        public Employees Employees { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
        public TcRecurTypes TcRecurTypes { get; set; }
    }
}
