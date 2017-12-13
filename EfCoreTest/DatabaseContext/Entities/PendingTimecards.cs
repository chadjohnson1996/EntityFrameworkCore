using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PendingTimecards
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public DateTime? Dated { get; set; }
        public string EarnTypeNo { get; set; }
        public decimal Hours { get; set; }
        public decimal PayRate { get; set; }
        public string TimecardCreated { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string TradeNo { get; set; }
        public string EquipmentNo { get; set; }
        public string ShiftNo { get; set; }
        public decimal JcQuantity { get; set; }
        public string TcDescription { get; set; }
        public decimal Amount { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string EquipmentId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public string ShiftId { get; set; }
        public string TradeId { get; set; }
        public string MdUser { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTime? EditDate { get; set; }
        public string EditReason { get; set; }
        public string EditUser { get; set; }
        public int? TimeCardsRowUniqueId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StartTimeMilitary { get; set; }
        public string StartTimeType { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? EndTimeMilitary { get; set; }
        public string EndTimeType { get; set; }
    }
}
