using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PaychkCorrect
    {
        public int CompanyNo { get; set; }
        public string PayMethod { get; set; }
        public decimal GlCash { get; set; }
        public int CheckNo { get; set; }
        public string CheckNoSource { get; set; }
        public int SequenceNo { get; set; }
        public string NewCheckOption { get; set; }
        public string VoidOption { get; set; }
        public string LockNetPay { get; set; }
        public string CopyTimecards { get; set; }
        public string PayDifference { get; set; }
        public string EmployeeNo { get; set; }
        public decimal? CheckAmount { get; set; }
        public int? TimecardXref { get; set; }
        public string PayPeriodNo { get; set; }
        public string PaymentGroupNo { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? PeriodStarts { get; set; }
        public DateTime? PeriodEnds { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string PreprocessReqd { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string PayPeriodId { get; set; }
        public string PaymentGroupId { get; set; }
        public string SequenceId { get; set; }
    }
}
