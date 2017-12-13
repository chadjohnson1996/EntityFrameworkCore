using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ItemVendors
    {
        public int CompanyNo { get; set; }
        public string ItemNo { get; set; }
        public string VendorNo { get; set; }
        public string PreferredFlag { get; set; }
        public string VendorItemNo { get; set; }
        public string VendorItemDesc { get; set; }
        public decimal VendorUnitPrice { get; set; }
        public string VendorUnitNo { get; set; }
        public decimal StockingUnitCost { get; set; }
        public string StockingUnitNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ItemId { get; set; }
        public string StockingUnitId { get; set; }
        public string VendorItemId { get; set; }
        public string VendorId { get; set; }
        public string VendorUnitId { get; set; }
        public string LastModifiedSource { get; set; }

        public Items Items { get; set; }
        public Units Units { get; set; }
        public Units UnitsNavigation { get; set; }
        public Vendors Vendors { get; set; }
    }
}
