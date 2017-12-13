using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class InventoryImport
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string Source { get; set; }
        public DateTime Date { get; set; }
        public string ImportStatus { get; set; }
        public string FullyAppliedCost { get; set; }
        public string FullyAppliedPrice { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string TransactionId { get; set; }
        public string ErrorMessage { get; set; }
        public string ImportResults { get; set; }
    }
}
