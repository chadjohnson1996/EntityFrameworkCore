using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PayChkStub1
    {
        public int CompanyNo { get; set; }
        public DateTime PostTimestamp { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriod { get; set; }
        public int ComputeSequence { get; set; }
        public string PayMethod { get; set; }
        public int OrdinalPosition { get; set; }
        public string EmployeeName { get; set; }
        public string EarningDesc { get; set; }
        public decimal EarningCurrent { get; set; }
        public decimal EarningYtd { get; set; }
        public string DeductDesc { get; set; }
        public decimal DeductCurrent { get; set; }
        public decimal DeductYtd { get; set; }
        public string PayRateDesc { get; set; }
        public decimal PayRateCurrent { get; set; }
        public decimal PayRateYtd { get; set; }
        public int? CheckNo { get; set; }
        public string SsNo { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? WeekEnding { get; set; }
        public string EarningCurrentText { get; set; }
        public string EarningYtdText { get; set; }
        public string DeductCurrentText { get; set; }
        public string PayRateCurrentText { get; set; }
        public DateTime? PrintDate { get; set; }
        public string Comment { get; set; }
        public string PeriodDates { get; set; }
        public string CommentDesc { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? SsNoEid { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string SsId { get; set; }
        public int? ShowZeroBalYtd { get; set; }

        public Employees Employees { get; set; }
        public Edata SsNoE { get; set; }
    }
}
