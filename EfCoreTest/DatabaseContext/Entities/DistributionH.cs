using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DistributionH
    {
        public DistributionH()
        {
            DistributionD = new HashSet<DistributionD>();
        }

        public int CompanyNo { get; set; }
        public string JournalNo { get; set; }
        public int TransactionNo { get; set; }
        public DateTime DateBooked { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? NextLineNo { get; set; }
        public string CompanyId { get; set; }
        public string JournalId { get; set; }
        public string NextLineId { get; set; }
        public string TransactionId { get; set; }

        public GlJournals GlJournals { get; set; }
        public ICollection<DistributionD> DistributionD { get; set; }
    }
}
