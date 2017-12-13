using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcFieldLogOnSiteContacts
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcFieldLogNo { get; set; }
        public int LineNo { get; set; }
        public string OnSiteContactType { get; set; }
        public string OnSiteContactNo { get; set; }
        public int? OnSiteContactLineNo { get; set; }
        public int Staff { get; set; }
        public string Notes { get; set; }
        public decimal Hours { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string TradeNo { get; set; }
        public string DeptNo { get; set; }
        public string EarnTypeNo { get; set; }
        public decimal Quantity { get; set; }
        public string EquipmentNo { get; set; }
        public string ShiftNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CostClassNo { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string DcFieldLogId { get; set; }
        public string DeptId { get; set; }
        public string EarnTypeId { get; set; }
        public string EquipmentId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string OnSiteContactLineId { get; set; }
        public string OnSiteContactId { get; set; }
        public string PhaseId { get; set; }
        public string ShiftId { get; set; }
        public string TradeId { get; set; }

        public DcFieldLogs DcFieldLogs { get; set; }
        public Jobs Jobs { get; set; }
        public CmContactPersons OnSiteContact { get; set; }
        public CmContacts OnSiteContactNoNavigation { get; set; }
    }
}
