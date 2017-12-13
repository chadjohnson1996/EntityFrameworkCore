using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisPositivePay
    {
        public int CompanyNo { get; set; }
        public int BatchNo { get; set; }
        public int ReportNo { get; set; }
        public DateTime ExportedOn { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BatchId { get; set; }
        public string CompanyId { get; set; }
        public string ReportId { get; set; }
        public decimal? GlAccountNo { get; set; }
        public string GlAccountId { get; set; }
    }
}
