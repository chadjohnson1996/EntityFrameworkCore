using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CashHistoryJournalH
    {
        public CashHistoryJournalH()
        {
            CashHistoryJournalD = new HashSet<CashHistoryJournalD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public decimal CashAccountNo { get; set; }
        public DateTime? DefaultDate { get; set; }
        public string Description { get; set; }
        public string PostedFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CashAccountId { get; set; }
        public string CompanyId { get; set; }
        public string TransactionId { get; set; }

        public Accounts C { get; set; }
        public ICollection<CashHistoryJournalD> CashHistoryJournalD { get; set; }
    }
}
