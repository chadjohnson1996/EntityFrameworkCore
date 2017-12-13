using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class GlHistoryPrDtl
    {
        public int CompanyNo { get; set; }
        public DateTime? DateBooked { get; set; }
        public string JournalNo { get; set; }
        public int? TransactionNo { get; set; }
        public decimal? FullAccountNo { get; set; }
        public string JobNo { get; set; }
        public decimal? BasicAccountNo { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public decimal? AmountDb { get; set; }
        public decimal? AmountCr { get; set; }
        public string PayMethod { get; set; }
        public decimal GlCash { get; set; }
        public int CheckNo { get; set; }
        public string CheckNoSource { get; set; }
        public int TimecardXref { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BasicAccountId { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string FullAccountId { get; set; }
        public string JobId { get; set; }
        public string JournalId { get; set; }
        public string PayPeriodId { get; set; }
        public string TransactionId { get; set; }
    }
}
