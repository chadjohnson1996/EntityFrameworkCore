using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DeprJournalH
    {
        public DeprJournalH()
        {
            DeprJournalD = new HashSet<DeprJournalD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string Source { get; set; }
        public string BookType { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string TransactionId { get; set; }

        public BookTypes BookTypes { get; set; }
        public ICollection<DeprJournalD> DeprJournalD { get; set; }
    }
}
