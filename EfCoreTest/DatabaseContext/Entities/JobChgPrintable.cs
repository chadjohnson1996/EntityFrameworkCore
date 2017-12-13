using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobChgPrintable
    {
        public int CompanyNo { get; set; }
        public string ChangeOrderNo { get; set; }
        public int ChangeOrderSeq { get; set; }
        public string JobNo { get; set; }
        public int LineNo { get; set; }
        public string CoText { get; set; }
        public decimal? ExtPrice { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ChangeOrderId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string AutoCreated { get; set; }
        public int OrdinalPosition { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string UnitNo { get; set; }
        public string UnitId { get; set; }

        public JobChg JobChg { get; set; }
    }
}
