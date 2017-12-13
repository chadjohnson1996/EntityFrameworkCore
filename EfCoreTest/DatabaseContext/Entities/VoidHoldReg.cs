using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class VoidHoldReg
    {
        public int CompanyNo { get; set; }
        public decimal GlCash { get; set; }
        public int CheckNo { get; set; }
        public string Type { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string PayPeriodNo { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string PayPeriodId { get; set; }
        public string CheckNoSource { get; set; }
    }
}
