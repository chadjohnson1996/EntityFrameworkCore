using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisPrAudit
    {
        public int CompanyNo { get; set; }
        public int AuditNumber { get; set; }
        public string PayPeriodNo { get; set; }
        public int FirstTimecardXref { get; set; }
        public int LastTimecardXref { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? PostedOn { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int GlTransactionNo { get; set; }
        public decimal GlCash { get; set; }
        public DateTime PrintDate { get; set; }
        public string CompanyId { get; set; }
        public string GlTransactionId { get; set; }
        public string PayPeriodId { get; set; }
    }
}
