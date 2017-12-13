using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqExpenseJournalH
    {
        public EqExpenseJournalH()
        {
            EqExpenseJournalD = new HashSet<EqExpenseJournalD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string Description { get; set; }
        public string JournalType { get; set; }
        public string DefaultEquipmentNo { get; set; }
        public string DefaultServiceCodeNo { get; set; }
        public DateTime? DefaultDate { get; set; }
        public string Source { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DefaultEquipmentId { get; set; }
        public string DefaultServiceCodeId { get; set; }
        public string TransactionId { get; set; }

        public EqServiceCodes EqServiceCodes { get; set; }
        public Equipment Equipment { get; set; }
        public ICollection<EqExpenseJournalD> EqExpenseJournalD { get; set; }
    }
}
