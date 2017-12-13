using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlFa
    {
        public int CompanyNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ControlDateFlag { get; set; }
        public string UpdateGl { get; set; }
        public string GlHisFlag { get; set; }
        public string JournalNo { get; set; }
        public decimal? GlAccumDepr { get; set; }
        public decimal? GlDeprExpense { get; set; }
        public string BookType { get; set; }
        public int? DefaultDiv1 { get; set; }
        public int? DefaultDiv2 { get; set; }
        public int? DefaultDiv3 { get; set; }
        public int? DefaultDiv4 { get; set; }
        public string EntryToSold { get; set; }
        public string EntryToMissing { get; set; }
        public string EntryToScrap { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JournalId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public BookTypes BookTypes { get; set; }
        public GlJournals GlJournals { get; set; }
    }
}
