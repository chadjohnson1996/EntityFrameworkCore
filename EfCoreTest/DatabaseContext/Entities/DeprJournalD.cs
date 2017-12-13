using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DeprJournalD
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string PostedFlag { get; set; }
        public string BookType { get; set; }
        public DateTime TransactionDate { get; set; }
        public string AssetNo { get; set; }
        public decimal Amount { get; set; }
        public decimal? GlDeprExpense { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }
        public decimal? FullGlDeprExpense { get; set; }
        public decimal? GlAccumDepr { get; set; }
        public string Method { get; set; }
        public string MethodCode { get; set; }
        public decimal FixedAmount { get; set; }
        public decimal? Year { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AssetId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string TransactionId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public BookTypes BookTypes { get; set; }
        public DeprJournalH DeprJournalH { get; set; }
        public DeprMethods DeprMethods { get; set; }
        public Equipment Equipment { get; set; }
    }
}
