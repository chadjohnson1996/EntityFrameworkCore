using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcFieldLogOnSiteLabor
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcFieldLogNo { get; set; }
        public int LineNo { get; set; }
        public string EmployeeNo { get; set; }
        public string Description { get; set; }
        public decimal Hours { get; set; }
        public decimal Amount { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string TradeNo { get; set; }
        public string DeptNo { get; set; }
        public string EarnTypeNo { get; set; }
        public decimal Quantity { get; set; }
        public string EquipmentNo { get; set; }
        public string ShiftNo { get; set; }
        public string TimecardCreated { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string DcFieldLogId { get; set; }
        public string DeptId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string EquipmentId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }
        public string ShiftId { get; set; }
        public string TradeId { get; set; }
        public int? TimeCardsRowUniqueId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StartTimeMilitary { get; set; }
        public string StartTimeType { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? EndTimeMilitary { get; set; }
        public string EndTimeType { get; set; }

        public CostCodes Co { get; set; }
        public Departments Departments { get; set; }
        public EarnTypes EarnTypes { get; set; }
        public Employees Employees { get; set; }
        public Equipment Equipment { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
        public Shifts Shifts { get; set; }
        public Trades Trades { get; set; }
    }
}
