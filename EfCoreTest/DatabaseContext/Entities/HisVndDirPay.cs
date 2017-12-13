using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisVndDirPay
    {
        public HisVndDirPay()
        {
            ApPmt = new HashSet<ApPmt>();
        }

        public int CompanyNo { get; set; }
        public int BatchNo { get; set; }
        public DateTime ExportedOn { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BatchId { get; set; }
        public string CompanyId { get; set; }

        public ICollection<ApPmt> ApPmt { get; set; }
    }
}
