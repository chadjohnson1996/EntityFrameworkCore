using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class GlJournalD
    {
        public int CompanyNo { get; set; }
        public string JournalNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public decimal BasicAccountNo { get; set; }
        public string DebitCredit { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Units { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string TradeNo { get; set; }
        public string EarnTypeNo { get; set; }
        public string Description { get; set; }
        public string BankRec { get; set; }
        public string CostCodeMethod { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }
        public decimal? FullAccountNo { get; set; }
        public string PostFlag { get; set; }
        public string UpdateJobHistory { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BasicAccountId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string EarnTypeId { get; set; }
        public string FullAccountId { get; set; }
        public string JobId { get; set; }
        public string JournalId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }
        public string TradeId { get; set; }
        public string TransactionId { get; set; }
        public int OrdinalPosition { get; set; }

        public Accounts Accounts { get; set; }
        public GlJournalH GlJournalH { get; set; }
        public Jobs Jobs { get; set; }
    }
}
