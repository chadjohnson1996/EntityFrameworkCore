using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqAttachmentUsage
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public int AttachmentLineNo { get; set; }
        public string PostedFlag { get; set; }
        public string AttachmentNo { get; set; }
        public decimal Units { get; set; }
        public string UnitType { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal? GlExpenseBase { get; set; }
        public decimal? GlExpenseDivLevel1 { get; set; }
        public decimal? GlExpenseDivLevel2 { get; set; }
        public decimal? GlExpenseDivLevel3 { get; set; }
        public decimal? GlExpenseDivLevel4 { get; set; }
        public decimal? GlExpenseFull { get; set; }
        public decimal? GlCreditBase { get; set; }
        public decimal? GlCreditDivLevel1 { get; set; }
        public decimal? GlCreditDivLevel2 { get; set; }
        public decimal? GlCreditDivLevel3 { get; set; }
        public decimal? GlCreditDivLevel4 { get; set; }
        public decimal? GlCreditFull { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AttachmentLineId { get; set; }
        public string AttachmentId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string TransactionId { get; set; }
        public string Reversal { get; set; }
        public int? OriginalEqUsageTransactionNo { get; set; }
        public string OriginalEqUsageTransactionId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public EqAttachments EqAttachments { get; set; }
        public EqUsage EqUsage { get; set; }
    }
}
