using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcRfcPrintable
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcRfcNo { get; set; }
        public int LineNo { get; set; }
        public int OrdinalPosition { get; set; }
        public string CoText { get; set; }
        public decimal ExtPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string UnitNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcRfcId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string UnitId { get; set; }

        public DcRfcs DcRfcs { get; set; }
    }
}
