using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PendingInventoryUsage
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public DateTime Date { get; set; }
        public string ItemNo { get; set; }
        public string FromFlag { get; set; }
        public string FromNo { get; set; }
        public decimal Quantity { get; set; }
        public string UnitNo { get; set; }
        public decimal UnitCost { get; set; }
        public string FromPhaseNo { get; set; }
        public string FromCostCodeNo { get; set; }
        public string FromCostClassNo { get; set; }
        public string ToPhaseNo { get; set; }
        public string ToCostCodeNo { get; set; }
        public string ToCostClassNo { get; set; }
        public string MdUser { get; set; }
        public string InvUsageCreated { get; set; }
        public string RecordStatus { get; set; }
        public string RowCreatedBy { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? InventoryJobDRowUniqueId { get; set; }
        public int? InventoryReceiptsDRowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string FromCostClassId { get; set; }
        public string FromCostCodeId { get; set; }
        public string FromId { get; set; }
        public string FromPhaseId { get; set; }
        public string ItemId { get; set; }
        public string JobId { get; set; }
        public string ToCostClassId { get; set; }
        public string ToCostCodeId { get; set; }
        public string ToPhaseId { get; set; }
        public string UnitId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
    }
}
