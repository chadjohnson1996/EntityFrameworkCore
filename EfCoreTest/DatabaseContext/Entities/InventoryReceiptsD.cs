using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class InventoryReceiptsD
    {
        public InventoryReceiptsD()
        {
            ApInvoiceItemD = new HashSet<ApInvoiceItemD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public string ItemNo { get; set; }
        public string DetailDescription { get; set; }
        public string ReceivedUnitNo { get; set; }
        public decimal ReceivedUnitCost { get; set; }
        public decimal ReceivedQuantity { get; set; }
        public string StockingUnitNo { get; set; }
        public decimal StockingQuantity { get; set; }
        public decimal StockingUnitCost { get; set; }
        public string DistributeTo { get; set; }
        public string JobNo { get; set; }
        public string WarehouseNo { get; set; }
        public decimal? GlExpense { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string ClearFlag { get; set; }
        public DateTime? ClearDate { get; set; }
        public decimal ExtendedCost { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string UnitCostChanged { get; set; }
        public int? OrigRcptTransactionNo { get; set; }
        public int? OrigRcptLineNo { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string ItemId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string OrigRcptLineId { get; set; }
        public string OrigRcptTransactionId { get; set; }
        public string PhaseId { get; set; }
        public string ReceivedUnitId { get; set; }
        public string StockingUnitId { get; set; }
        public string TransactionId { get; set; }
        public string WarehouseId { get; set; }
        public string EquipmentNo { get; set; }
        public string EqWoNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public string EqWoId { get; set; }
        public string EquipmentId { get; set; }
        public string ServiceCodeId { get; set; }
        public string Selected { get; set; }
        public string ClearReceipt { get; set; }
        public string LineComment { get; set; }
        public string DcFieldLogNo { get; set; }
        public int? FieldLogMatLineNo { get; set; }
        public string DcFieldLogId { get; set; }
        public string FieldLogMatLineId { get; set; }
        public string TaxFlag { get; set; }
        public string TaxNo { get; set; }
        public string TaxId { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }
        public decimal? FullGlExpense { get; set; }

        public Accounts Accounts { get; set; }
        public CostClasses Co { get; set; }
        public CostCodes CoNavigation { get; set; }
        public DcFieldLogMaterials DcFieldLogMaterials { get; set; }
        public InventoryReceiptsH InventoryReceiptsH { get; set; }
        public Items Items { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
        public Units Units { get; set; }
        public Units UnitsNavigation { get; set; }
        public Warehouses Warehouses { get; set; }
        public ICollection<ApInvoiceItemD> ApInvoiceItemD { get; set; }
    }
}
