using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisChkStubExtended
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
        public string PhoneVoice { get; set; }
        public string EmployeeName { get; set; }
        public string CommentDesc1 { get; set; }
        public string CommentTxt1 { get; set; }
        public string CommentDesc2 { get; set; }
        public string CommentTxt2 { get; set; }
        public string CommentDesc3 { get; set; }
        public string CommentTxt3 { get; set; }
        public string CommentDesc4 { get; set; }
        public string CommentTxt4 { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public int? ShowTitle1 { get; set; }
        public int? ShowTitle2 { get; set; }
        public int? ShowLine { get; set; }
        public int? ShowHeadings1 { get; set; }
        public int? ShowHeadings2 { get; set; }
        public int? ShowHoursPayrate1 { get; set; }
        public int? ShowHoursPayrate2 { get; set; }
        public int? ShowFrgBen1 { get; set; }
        public int? ShowFrgBen2 { get; set; }
        public int? ShowAccruals1 { get; set; }
        public int? ShowAccruals2 { get; set; }
        public string Desc1 { get; set; }
        public string Desc2 { get; set; }
        public decimal Hours1 { get; set; }
        public decimal Hours2 { get; set; }
        public decimal PayRate1 { get; set; }
        public decimal Hrsytd1 { get; set; }
        public decimal PayRate2 { get; set; }
        public decimal Current1 { get; set; }
        public decimal Current2 { get; set; }
        public decimal Ytd1 { get; set; }
        public decimal Ytd2 { get; set; }
        public int? Weight1 { get; set; }
        public int? Weight2 { get; set; }
        public string SsNo { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? WeekEnding { get; set; }
        public DateTime? PrintDate { get; set; }
        public string Comment { get; set; }
        public string LogoFilename { get; set; }
        public string PeriodDates { get; set; }
        public DateTime? DateBooked { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? SsNoEid { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string SsId { get; set; }
        public int? ShowZeroBal1 { get; set; }
        public int? ShowZeroBal2 { get; set; }

        public Employees Employees { get; set; }
        public Edata SsNoE { get; set; }
    }
}
