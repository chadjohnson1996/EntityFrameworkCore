using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqWoJournal
    {
        public EqWoJournal()
        {
            EqWoJournalItems = new HashSet<EqWoJournalItems>();
            EqWoJournalNonInv = new HashSet<EqWoJournalNonInv>();
            InventoryActivityH = new HashSet<InventoryActivityH>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string PostedFlag { get; set; }
        public DateTime TransactionDate { get; set; }
        public string EqWoNo { get; set; }
        public decimal HoursMeterBalance { get; set; }
        public decimal OdometerBalance { get; set; }
        public decimal OtherMeterBalance { get; set; }
        public string CloseFlag { get; set; }
        public string Comments { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EqWoId { get; set; }
        public string TransactionId { get; set; }

        public EqWo EqWo { get; set; }
        public ICollection<EqWoJournalItems> EqWoJournalItems { get; set; }
        public ICollection<EqWoJournalNonInv> EqWoJournalNonInv { get; set; }
        public ICollection<InventoryActivityH> InventoryActivityH { get; set; }
    }
}
