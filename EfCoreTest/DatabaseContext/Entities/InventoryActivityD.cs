using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class InventoryActivityD
    {
        public InventoryActivityD()
        {
            InventoryActivityTransferD = new HashSet<InventoryActivityTransferD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public string ItemNo { get; set; }
        public string DeliveryUnitNo { get; set; }
        public decimal DeliveryUnitCost { get; set; }
        public string StockingUnitNo { get; set; }
        public decimal StockingUnitCost { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? InvRcptTrxNo { get; set; }
        public int? InvRcptLineNo { get; set; }
        public string CompanyId { get; set; }
        public string DeliveryUnitId { get; set; }
        public string InvRcptLineId { get; set; }
        public string InvRcptTrxId { get; set; }
        public string ItemId { get; set; }
        public string LineId { get; set; }
        public string StockingUnitId { get; set; }
        public string TransactionId { get; set; }
        public int? InWoNo { get; set; }
        public int? InWoLineNo { get; set; }
        public string InWoLineId { get; set; }
        public string InWoId { get; set; }

        public InventoryActivityH InventoryActivityH { get; set; }
        public InventoryWorksheetsD InventoryWorksheetsD { get; set; }
        public Items Items { get; set; }
        public Units Units { get; set; }
        public Units UnitsNavigation { get; set; }
        public ICollection<InventoryActivityTransferD> InventoryActivityTransferD { get; set; }
    }
}
