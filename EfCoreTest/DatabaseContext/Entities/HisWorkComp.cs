using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisWorkComp
    {
        public int CompanyNo { get; set; }
        public string State { get; set; }
        public string WcClassNo { get; set; }
        public string TradeNo { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime DateBooked { get; set; }
        public string JobNo { get; set; }
        public string PayPeriodNo { get; set; }
        public int LineNo { get; set; }
        public int TimecardXref { get; set; }
        public decimal? Exposure { get; set; }
        public decimal? Hours { get; set; }
        public decimal? PremiumRate { get; set; }
        public decimal? Premium { get; set; }
        public string Include { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public decimal? Gross { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public decimal? ExposureHours { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PayPeriodId { get; set; }
        public string TradeId { get; set; }
        public string WcClassId { get; set; }
        public string EarnTypeNo { get; set; }
        public decimal? EmployeePremiumRate { get; set; }
        public decimal? EmployeePremium { get; set; }
        public string DeductionNo { get; set; }
        public string DeductionId { get; set; }
        public string EarnTypeId { get; set; }
        public string SortJobNo { get; set; }
        public string SortJobId { get; set; }

        public Employees Employees { get; set; }
        public Jobs Jobs { get; set; }
    }
}
