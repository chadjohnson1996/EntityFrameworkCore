using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class InventoryWorksheetsD
    {
        public InventoryWorksheetsD()
        {
            InventoryActivityD = new HashSet<InventoryActivityD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string ItemNo { get; set; }
        public string CategoryNo { get; set; }
        public string DciAlternate { get; set; }
        public string StockingUnitNo { get; set; }
        public decimal ComputerCount { get; set; }
        public decimal PhysicalCount { get; set; }
        public string PhysicalCountType { get; set; }
        public string ZeroFlag { get; set; }
        public string CounterInitials { get; set; }
        public string Comments { get; set; }
        public decimal QuantityAdjustment { get; set; }
        public decimal UnitCost { get; set; }
        public decimal DollarAdjustment { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CategoryId { get; set; }
        public string CompanyId { get; set; }
        public string ItemId { get; set; }
        public string LineId { get; set; }
        public string StockingUnitId { get; set; }
        public string TransactionId { get; set; }

        public ItemCategories C { get; set; }
        public InventoryWorksheetsH InventoryWorksheetsH { get; set; }
        public Items Items { get; set; }
        public Units Units { get; set; }
        public ICollection<InventoryActivityD> InventoryActivityD { get; set; }
    }
}
