using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PendingEqUsage
    {
        public int CompanyNo { get; set; }
        public string EquipmentNo { get; set; }
        public DateTime DateBooked { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public decimal Units { get; set; }
        public string UnitType { get; set; }
        public string MdUser { get; set; }
        public string EqUsageCreated { get; set; }
        public string RecordStatus { get; set; }
        public string RowCreatedBy { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string EquipmentId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public int? EqUsageRowUniqueId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
    }
}
