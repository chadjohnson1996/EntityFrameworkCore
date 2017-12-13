using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqMeterJournalH
    {
        public EqMeterJournalH()
        {
            EqMeterJournalD = new HashSet<EqMeterJournalD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string Description { get; set; }
        public string PostedFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string TransactionId { get; set; }

        public ICollection<EqMeterJournalD> EqMeterJournalD { get; set; }
    }
}
