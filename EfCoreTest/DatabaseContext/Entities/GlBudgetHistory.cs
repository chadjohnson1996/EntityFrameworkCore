using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class GlBudgetHistory
    {
        public int CompanyNo { get; set; }
        public decimal BasicAccountNo { get; set; }
        public decimal? FullAccountNo { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }
        public string JobNo { get; set; }
        public DateTime? BookDate { get; set; }
        public DateTime? DatePosted { get; set; }
        public string JournalNo { get; set; }
        public int? TransactionNo { get; set; }
        public int? LineNo { get; set; }
        public decimal? AmountDb { get; set; }
        public decimal? AmountCr { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BasicAccountId { get; set; }
        public string CompanyId { get; set; }
        public string FullAccountId { get; set; }
        public string JobId { get; set; }
        public string JournalId { get; set; }
        public string LineId { get; set; }
        public string TransactionId { get; set; }

        public Accounts Accounts { get; set; }
        public GlJournals GlJournals { get; set; }
        public Jobs Jobs { get; set; }
    }
}
