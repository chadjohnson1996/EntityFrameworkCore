using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class InventoryJobMatD
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string InvJobMatNo { get; set; }
        public int LineNo { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string PurchasingUnitNo { get; set; }
        public decimal Quantity { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string InvJobMatId { get; set; }
        public string ItemId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PurchasingUnitId { get; set; }

        public Jobs Jobs { get; set; }
        public Units Units { get; set; }
    }
}
