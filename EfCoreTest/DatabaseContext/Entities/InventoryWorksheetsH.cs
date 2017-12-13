using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class InventoryWorksheetsH
    {
        public InventoryWorksheetsH()
        {
            InventoryActivityH = new HashSet<InventoryActivityH>();
            InventoryWorksheetsD = new HashSet<InventoryWorksheetsD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string WarehouseNo { get; set; }
        public DateTime PostDate { get; set; }
        public string WorksheetStatus { get; set; }
        public string PrintStatus { get; set; }
        public string SortOrder { get; set; }
        public string StartItemNo { get; set; }
        public string EndItemNo { get; set; }
        public string StartDescription { get; set; }
        public string EndDescription { get; set; }
        public string StartPrimaryCatNo { get; set; }
        public string EndPrimaryCatNo { get; set; }
        public string StartBinLocationNo { get; set; }
        public string EndBinLocationNo { get; set; }
        public string DefaultInitials { get; set; }
        public DateTime AsOfDate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string UnitCostDefault { get; set; }
        public string CalculateAverageFlag { get; set; }
        public decimal CalculateAverageMonths { get; set; }
        public DateTime? HisStartDate { get; set; }
        public string CompanyId { get; set; }
        public string EndBinLocationId { get; set; }
        public string EndItemId { get; set; }
        public string EndPrimaryCatId { get; set; }
        public string StartBinLocationId { get; set; }
        public string StartItemId { get; set; }
        public string StartPrimaryCatId { get; set; }
        public string TransactionId { get; set; }
        public string WarehouseId { get; set; }
        public string Reversal { get; set; }
        public int? OriginalTransactionNo { get; set; }
        public string ItemNo1 { get; set; }
        public string ItemNo2 { get; set; }
        public string ItemNo3 { get; set; }
        public string ItemNo4 { get; set; }
        public string ItemNo5 { get; set; }
        public string ItemNo6 { get; set; }
        public string ItemNo7 { get; set; }
        public string ItemNo8 { get; set; }
        public string ItemNo9 { get; set; }
        public string ItemNo10 { get; set; }
        public string OriginalTransactionId { get; set; }

        public Warehouses Warehouses { get; set; }
        public ICollection<InventoryActivityH> InventoryActivityH { get; set; }
        public ICollection<InventoryWorksheetsD> InventoryWorksheetsD { get; set; }
    }
}
