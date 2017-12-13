using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ItemStdCostH
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public string StartItemNo { get; set; }
        public string EndItemNo { get; set; }
        public string StartDescription { get; set; }
        public string EndDescription { get; set; }
        public string StartPrimeCategory { get; set; }
        public string EndPrimeCategory { get; set; }
        public string VendorNo { get; set; }
        public string SortOrder { get; set; }
        public string FullItemDesc { get; set; }
        public string PostedFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EndItemId { get; set; }
        public string StartItemId { get; set; }
        public string TransactionId { get; set; }
        public string VendorId { get; set; }
    }
}
