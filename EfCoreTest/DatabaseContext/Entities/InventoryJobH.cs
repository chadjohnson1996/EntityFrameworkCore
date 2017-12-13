using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class InventoryJobH
    {
        public InventoryJobH()
        {
            InventoryJobD = new HashSet<InventoryJobD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public DateTime Dated { get; set; }
        public string Comments { get; set; }
        public string TransferFrom { get; set; }
        public string FromWarehouseNo { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string FromPriceLevelNo { get; set; }
        public decimal FromUnitPrice { get; set; }
        public string FromTaxNo { get; set; }
        public string TransferTo { get; set; }
        public string ToWarehouseNo { get; set; }
        public string ToJobNo { get; set; }
        public string ToPhaseNo { get; set; }
        public string ToCostCodeNo { get; set; }
        public string ToCostClassNo { get; set; }
        public string ToPriceLevelNo { get; set; }
        public decimal ToUnitPrice { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string FromPriceLevelId { get; set; }
        public string FromTaxId { get; set; }
        public string FromWarehouseId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public string ToCostClassId { get; set; }
        public string ToCostCodeId { get; set; }
        public string ToJobId { get; set; }
        public string ToPhaseId { get; set; }
        public string ToPriceLevelId { get; set; }
        public string ToWarehouseId { get; set; }
        public string TransactionId { get; set; }
        public string HoldFlag { get; set; }
        public string ShipToLine1 { get; set; }
        public string ShipToLine2 { get; set; }
        public string ShipToLine3 { get; set; }
        public string ShipToLine4 { get; set; }
        public string OrderedBy { get; set; }
        public string PrintedFlag { get; set; }
        public string MultDestin { get; set; }
        public string Notes { get; set; }
        public string Source { get; set; }
        public decimal? FromGlExpense { get; set; }
        public decimal? FromDivLevel1 { get; set; }
        public decimal? FromDivLevel2 { get; set; }
        public decimal? FromDivLevel3 { get; set; }
        public decimal? FromDivLevel4 { get; set; }
        public decimal? FromFullGlExpense { get; set; }
        public decimal? ToGlExpense { get; set; }
        public decimal? ToDivLevel1 { get; set; }
        public decimal? ToDivLevel2 { get; set; }
        public decimal? ToDivLevel3 { get; set; }
        public decimal? ToDivLevel4 { get; set; }
        public decimal? ToFullGlExpense { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public CostClasses Co { get; set; }
        public CostCodes CoNavigation { get; set; }
        public CostClasses CostClasses { get; set; }
        public CostCodes CostCodes { get; set; }
        public Jobs Jobs { get; set; }
        public Jobs JobsNavigation { get; set; }
        public Phases Phases { get; set; }
        public Phases PhasesNavigation { get; set; }
        public PriceLevels PriceLevels { get; set; }
        public PriceLevels PriceLevelsNavigation { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public Warehouses Warehouses { get; set; }
        public Warehouses WarehousesNavigation { get; set; }
        public ICollection<InventoryJobD> InventoryJobD { get; set; }
    }
}
