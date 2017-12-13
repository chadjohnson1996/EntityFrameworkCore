using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobTrxHdr
    {
        public JobTrxHdr()
        {
            JobTrx = new HashSet<JobTrx>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string JobNo { get; set; }
        public string Description { get; set; }
        public DateTime DateBooked { get; set; }
        public string PostFlag { get; set; }
        public int NextLineNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string JobTrxType { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public string NextLineId { get; set; }
        public string TransactionId { get; set; }
        public string Source { get; set; }

        public ICollection<JobTrx> JobTrx { get; set; }
    }
}
