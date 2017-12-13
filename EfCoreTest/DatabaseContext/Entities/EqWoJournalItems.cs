using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqWoJournalItems
    {
        public EqWoJournalItems()
        {
            EqWoJournalItemsD = new HashSet<EqWoJournalItemsD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string PostedFlag { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string UnitNo { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal ExtendedCost { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ItemId { get; set; }
        public string LineId { get; set; }
        public string TransactionId { get; set; }
        public string UnitId { get; set; }
        public string StockingUnitNo { get; set; }
        public decimal StockingUnitCost { get; set; }
        public string StockingUnitId { get; set; }
        public string ConvertFlag { get; set; }

        public EqWoJournal EqWoJournal { get; set; }
        public Items Items { get; set; }
        public Units Units { get; set; }
        public Units UnitsNavigation { get; set; }
        public ICollection<EqWoJournalItemsD> EqWoJournalItemsD { get; set; }
    }
}
