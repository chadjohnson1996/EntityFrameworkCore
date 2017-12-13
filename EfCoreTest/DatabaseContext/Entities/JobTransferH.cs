using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobTransferH
    {
        public JobTransferH()
        {
            JobTransferFromD = new HashSet<JobTransferFromD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public DateTime Date { get; set; }
        public string Comments { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string TransactionId { get; set; }

        public ICollection<JobTransferFromD> JobTransferFromD { get; set; }
    }
}
