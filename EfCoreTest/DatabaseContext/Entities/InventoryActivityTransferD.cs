using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class InventoryActivityTransferD
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public int TransferLineNo { get; set; }
        public string TransferType { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public decimal DeliveryQuantity { get; set; }
        public decimal ExtendedCost { get; set; }
        public decimal StockingQuantity { get; set; }
        public string MoveFromTo { get; set; }
        public string JobNo { get; set; }
        public string WarehouseNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string PriceLevelNo { get; set; }
        public decimal? UnitPrice { get; set; }
        public string TaxNo { get; set; }
        public int? InvRcptTrxNo { get; set; }
        public decimal? GlExpense { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? InvRcptLineNo { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string InvRcptLineId { get; set; }
        public string InvRcptTrxId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }
        public string PriceLevelId { get; set; }
        public string TaxId { get; set; }
        public string TransactionId { get; set; }
        public string TransferLineId { get; set; }
        public string WarehouseId { get; set; }
        public string AdjUseTax { get; set; }
        public string TaxByEffdateFlag { get; set; }
        public decimal? TaxPercent { get; set; }
        public decimal? StateTaxPercent { get; set; }
        public decimal? LocalTaxPercent { get; set; }
        public decimal? OtherTaxPercent { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }
        public decimal? FullGlExpense { get; set; }

        public Accounts Accounts { get; set; }
        public CostClasses Co { get; set; }
        public CostCodes CoNavigation { get; set; }
        public InventoryActivityD InventoryActivityD { get; set; }
        public InventoryReceiptsH InventoryReceiptsH { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
        public PriceLevels PriceLevels { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public Warehouses Warehouses { get; set; }
    }
}
