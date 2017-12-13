using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisChkStubCroell
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public int TimecardXref { get; set; }
        public string PayPeriod { get; set; }
        public string PayMethod { get; set; }
        public decimal GlCash { get; set; }
        public int CheckNo { get; set; }
        public string CheckNoSource { get; set; }
        public int OrdinalPosition { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string CityState { get; set; }
        public string EmployeeName { get; set; }
        public string EarningDesc { get; set; }
        public string AccrualDesc1 { get; set; }
        public decimal AccrualHours1 { get; set; }
        public string AccrualDesc2 { get; set; }
        public decimal AccrualHours2 { get; set; }
        public decimal EarningHours { get; set; }
        public decimal EarningPayRate { get; set; }
        public decimal EarningCurrent { get; set; }
        public decimal EarningYtd { get; set; }
        public string LogoFilename { get; set; }
        public int? Weight { get; set; }
        public int? ShowDeductionHeadings { get; set; }
        public int? ShowEarningHeadings { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? WeekEnding { get; set; }
        public DateTime? PrintDate { get; set; }
        public string Comment { get; set; }
        public DateTime? DateBooked { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string AccrualUnlimited1 { get; set; }
        public string AccrualUnlimited2 { get; set; }

        public Employees Employees { get; set; }
    }
}
