using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlMd
    {
        public int CompanyNo { get; set; }
        public string ShowEquipmentNo { get; set; }
        public string RequireEquipmentNo { get; set; }
        public string ShowJcQuantity { get; set; }
        public string RequireJcQuantity { get; set; }
        public string ShowTcDescription { get; set; }
        public string RequireTcDescription { get; set; }
        public string ShowShiftNo { get; set; }
        public string RequireShiftNo { get; set; }
        public string ShowTradeNo { get; set; }
        public string RequireTradeNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string RequireEquipmentId { get; set; }
        public string RequireShiftId { get; set; }
        public string RequireTradeId { get; set; }
        public string ShowEquipmentId { get; set; }
        public string ShowShiftId { get; set; }
        public string ShowTradeId { get; set; }
        public string ForceMdPmApproval { get; set; }
        public string TimeLock { get; set; }
        public string FilterAllClosedJobs { get; set; }
        public DateTime? ContractJobFilterDate { get; set; }
        public DateTime? ServiceJobFilterDate { get; set; }
        public string JobFilterNoClosedDate { get; set; }
    }
}
