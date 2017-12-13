using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobHistoryPrBrdDtl
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public int UpdateRowUniqueId { get; set; }
        public int JobBurdenUniqueId { get; set; }
        public int HoursUniqueId { get; set; }
        public string BurdenType { get; set; }
        public string EmployeeNo { get; set; }
        public string TradeNo { get; set; }
        public string EarnTypeNo { get; set; }
        public string DeptNo { get; set; }
        public DateTime? DateBooked { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public int LineNo { get; set; }
        public int? TimecardXref { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Earnings { get; set; }
        public decimal? Amount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string DeptId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }
        public string TradeId { get; set; }

        public BurdenTypes BurdenTypeNavigation { get; set; }
        public CostCodes Co { get; set; }
        public Departments Departments { get; set; }
        public EarnTypes EarnTypes { get; set; }
        public Employees Employees { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
        public Trades Trades { get; set; }
    }
}
