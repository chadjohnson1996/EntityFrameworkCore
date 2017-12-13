using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ArCashDistribution
    {
        public int CompanyNo { get; set; }
        public int CashReceiptNo { get; set; }
        public int LineNo { get; set; }
        public string PostedFlag { get; set; }
        public decimal? GlDebit { get; set; }
        public decimal? GlCredit { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CashReceiptId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }
        public decimal? GlCreditDivLevel1 { get; set; }
        public decimal? GlCreditDivLevel2 { get; set; }
        public decimal? GlCreditDivLevel3 { get; set; }
        public decimal? GlCreditDivLevel4 { get; set; }
        public decimal? GlCreditFullAccountNo { get; set; }
        public string GlCreditFullAccountId { get; set; }

        public ArCash C { get; set; }
    }
}
