using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PoSubChangeItemD
    {
        public int CompanyNo { get; set; }
        public string PoSubNo { get; set; }
        public string ChangeOrderNo { get; set; }
        public int ChangeOrderLineNo { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public string PurchasingUnitNo { get; set; }
        public decimal UnitCost { get; set; }
        public decimal ExtendedCost { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string PoSubId { get; set; }
        public string ChangeOrderId { get; set; }
        public string ItemId { get; set; }
        public string PurchasingUnitId { get; set; }
        public string ChangeOrderLineId { get; set; }
        public string DetailDescription { get; set; }
        public string StockingUnitNo { get; set; }
        public decimal StockingQuantity { get; set; }
        public decimal StockingUnitCost { get; set; }
        public string DistributeTo { get; set; }
        public string JobNo { get; set; }
        public string WarehouseNo { get; set; }
        public string TaxFlag { get; set; }
        public decimal TaxBase { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal? GlExpense { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string InventoryReceiptFlag { get; set; }
        public string ClearFlag { get; set; }
        public DateTime? ClearDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? OrderCompletionDate { get; set; }
        public decimal BackorderQty { get; set; }
        public DateTime? BackorderDate { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public string StockingUnitId { get; set; }
        public string WarehouseId { get; set; }
        public string EquipmentNo { get; set; }
        public string EqWoNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public string EqWoId { get; set; }
        public string EquipmentId { get; set; }
        public string ServiceCodeId { get; set; }
        public string PrintableFlag { get; set; }
        public string DispatchNo { get; set; }
        public string DispatchBilling { get; set; }
        public string DeliveryUnitNo { get; set; }
        public decimal DeliveryQuantity { get; set; }
        public decimal DeliveryUnitCost { get; set; }
        public string DeliveryUnitId { get; set; }
        public string DispatchId { get; set; }
        public string TaxByEffdateFlag { get; set; }
        public decimal? StateTaxPercent { get; set; }
        public decimal? StateTaxableLimit { get; set; }
        public decimal? StateTaxAmount { get; set; }
        public decimal? LocalTaxPercent { get; set; }
        public decimal? LocalTaxableLimit { get; set; }
        public decimal? LocalTaxAmount { get; set; }
        public decimal? OtherTaxPercent { get; set; }
        public decimal? OtherTaxableLimit { get; set; }
        public decimal? OtherTaxAmount { get; set; }
        public decimal? StateLimitApplied { get; set; }
        public decimal? LocalLimitApplied { get; set; }
        public decimal? OtherLimitApplied { get; set; }
        public decimal? ItemDivLevel1 { get; set; }
        public decimal? ItemDivLevel2 { get; set; }
        public decimal? ItemDivLevel3 { get; set; }
        public decimal? ItemDivLevel4 { get; set; }
        public decimal? FullGlExpense { get; set; }

        public Accounts Accounts { get; set; }
        public CostClasses Co { get; set; }
        public CostCodes CoNavigation { get; set; }
        public Items Items { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
        public PoSubChangeH PoSubChangeH { get; set; }
        public Units Units { get; set; }
        public Units Units1 { get; set; }
        public Units UnitsNavigation { get; set; }
        public Warehouses Warehouses { get; set; }
    }
}
