using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ItemStdCostD
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string StockUnitNo { get; set; }
        public string DeliveryUnitNo { get; set; }
        public string PrimaryItemCategoryNo { get; set; }
        public string CurrentCalcUnitCost { get; set; }
        public string NewCalcUnitCost { get; set; }
        public decimal CurrentStandardCost { get; set; }
        public decimal NewStandardCost { get; set; }
        public string ZeroStandardCost { get; set; }
        public string CurrentBase { get; set; }
        public string NewBase { get; set; }
        public string CurrentOperation { get; set; }
        public string NewOperation { get; set; }
        public decimal CurrentAmount { get; set; }
        public decimal NewAmount { get; set; }
        public string VendorNo { get; set; }
        public string PreferredVendor { get; set; }
        public string VendorItemNo { get; set; }
        public string VendorItemDesc { get; set; }
        public string VendorUm { get; set; }
        public decimal CurrentVendorPrice { get; set; }
        public decimal NewVendorPrice { get; set; }
        public string ZeroVendorPrice { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeliveryUnitId { get; set; }
        public string ItemId { get; set; }
        public string LineId { get; set; }
        public string PrimaryItemCategoryId { get; set; }
        public string StockUnitId { get; set; }
        public string TransactionId { get; set; }
        public string VendorItemId { get; set; }
        public string VendorId { get; set; }
    }
}
