using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class InventoryMatRecD
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string OriginalTransfer { get; set; }
        public string OriginalSource { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string DeliveryUnitNo { get; set; }
        public string VendorNo { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DistributeReturn { get; set; }
        public string WarehouseNo { get; set; }
        public string JobNo { get; set; }
        public decimal ReturnQuantity { get; set; }
        public decimal ReturnUnitPrice { get; set; }
        public decimal ReturnExtendedCost { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public decimal ToQuantity { get; set; }
        public string DistributeTo { get; set; }
        public string ToWarehouseNo { get; set; }
        public string ToJobNo { get; set; }
        public string ToPhaseNo { get; set; }
        public string ToCostCodeNo { get; set; }
        public string ToCostClassNo { get; set; }
        public decimal ToExtendedCost { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ReceiveInventoryThruAp { get; set; }
        public string OriginalTransaction { get; set; }
        public string ReversalTransaction { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string DeliveryUnitId { get; set; }
        public string ItemId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }
        public string ToCostClassId { get; set; }
        public string ToCostCodeId { get; set; }
        public string ToJobId { get; set; }
        public string ToPhaseId { get; set; }
        public string ToWarehouseId { get; set; }
        public string TransactionId { get; set; }
        public string VendorId { get; set; }
        public string WarehouseId { get; set; }

        public Items Items { get; set; }
    }
}
