using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Warehouses
    {
        public Warehouses()
        {
            ApShipTo = new HashSet<ApShipTo>();
            ArInvoiceFrmItemsD = new HashSet<ArInvoiceFrmItemsD>();
            ControlAr = new HashSet<ControlAr>();
            ControlEq = new HashSet<ControlEq>();
            ControlIn = new HashSet<ControlIn>();
            Customers = new HashSet<Customers>();
            EqWoItemsD = new HashSet<EqWoItemsD>();
            EqWoJournalItemsD = new HashSet<EqWoJournalItemsD>();
            InventoryActivityTransferD = new HashSet<InventoryActivityTransferD>();
            InventoryJobD = new HashSet<InventoryJobD>();
            InventoryJobHWarehouses = new HashSet<InventoryJobH>();
            InventoryJobHWarehousesNavigation = new HashSet<InventoryJobH>();
            InventoryMatRecH = new HashSet<InventoryMatRecH>();
            InventoryReceiptsD = new HashSet<InventoryReceiptsD>();
            InventoryWorksheetsH = new HashSet<InventoryWorksheetsH>();
            PoSubChangeItemD = new HashSet<PoSubChangeItemD>();
            PoSubItemD = new HashSet<PoSubItemD>();
            ShipTo = new HashSet<ShipTo>();
            WarehouseDivisions = new HashSet<WarehouseDivisions>();
        }

        public int CompanyNo { get; set; }
        public string WarehouseNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string WarehouseId { get; set; }
        public string TruckFlag { get; set; }
        public string ApTaxNo { get; set; }
        public decimal? GlInventoryIncome { get; set; }
        public decimal? GlMaterialExpense { get; set; }
        public decimal? GlInventoryAsset { get; set; }
        public decimal? GlReconciliation { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string SalesTaxJobNo { get; set; }
        public string SalesTaxPhaseNo { get; set; }
        public string SalesTaxCostCodeNo { get; set; }
        public string SalesTaxCostClassNo { get; set; }
        public string ApTaxId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public string SalesTaxCostClassId { get; set; }
        public string SalesTaxCostCodeId { get; set; }
        public string SalesTaxJobId { get; set; }
        public string SalesTaxPhaseId { get; set; }
        public string ReconJobNo { get; set; }
        public string ReconPhaseNo { get; set; }
        public string ReconCostCodeNo { get; set; }
        public string ReconCostClassNo { get; set; }
        public string ReconCostClassId { get; set; }
        public string ReconCostCodeId { get; set; }
        public string ReconJobId { get; set; }
        public string ReconPhaseId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts Accounts1 { get; set; }
        public Accounts Accounts2 { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public CostClasses Co { get; set; }
        public CostCodes CoNavigation { get; set; }
        public CostClasses CostClasses { get; set; }
        public CostClasses CostClassesNavigation { get; set; }
        public CostCodes CostCodes { get; set; }
        public CostCodes CostCodesNavigation { get; set; }
        public Jobs Jobs { get; set; }
        public Jobs Jobs1 { get; set; }
        public Jobs JobsNavigation { get; set; }
        public Phases Phases { get; set; }
        public Phases Phases1 { get; set; }
        public Phases PhasesNavigation { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public ICollection<ApShipTo> ApShipTo { get; set; }
        public ICollection<ArInvoiceFrmItemsD> ArInvoiceFrmItemsD { get; set; }
        public ICollection<ControlAr> ControlAr { get; set; }
        public ICollection<ControlEq> ControlEq { get; set; }
        public ICollection<ControlIn> ControlIn { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<EqWoItemsD> EqWoItemsD { get; set; }
        public ICollection<EqWoJournalItemsD> EqWoJournalItemsD { get; set; }
        public ICollection<InventoryActivityTransferD> InventoryActivityTransferD { get; set; }
        public ICollection<InventoryJobD> InventoryJobD { get; set; }
        public ICollection<InventoryJobH> InventoryJobHWarehouses { get; set; }
        public ICollection<InventoryJobH> InventoryJobHWarehousesNavigation { get; set; }
        public ICollection<InventoryMatRecH> InventoryMatRecH { get; set; }
        public ICollection<InventoryReceiptsD> InventoryReceiptsD { get; set; }
        public ICollection<InventoryWorksheetsH> InventoryWorksheetsH { get; set; }
        public ICollection<PoSubChangeItemD> PoSubChangeItemD { get; set; }
        public ICollection<PoSubItemD> PoSubItemD { get; set; }
        public ICollection<ShipTo> ShipTo { get; set; }
        public ICollection<WarehouseDivisions> WarehouseDivisions { get; set; }
    }
}
