using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisJob
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string EmployeeNo { get; set; }
        public string TradeNo { get; set; }
        public string EarnTypeNo { get; set; }
        public decimal JobRate { get; set; }
        public DateTime DateBooked { get; set; }
        public string PayPeriodNo { get; set; }
        public string PayMethod { get; set; }
        public string DeptNo { get; set; }
        public string CertifiedPayroll { get; set; }
        public int LineNo { get; set; }
        public int TimecardXref { get; set; }
        public decimal? JobWages { get; set; }
        public decimal? JobAdd { get; set; }
        public string FicaFlag { get; set; }
        public string FitFlag { get; set; }
        public string SitFlag { get; set; }
        public string LitFlag { get; set; }
        public string UniDedFlag { get; set; }
        public decimal? TotalHours { get; set; }
        public string PrevailFlag { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public decimal? Fringe { get; set; }
        public decimal? TaxableFringe { get; set; }
        public string CountyPrNo { get; set; }
        public DateTime? DatePosted { get; set; }
        public DateTime? DateWorked1 { get; set; }
        public decimal? Hours1 { get; set; }
        public DateTime? DateWorked2 { get; set; }
        public decimal? Hours2 { get; set; }
        public DateTime? DateWorked3 { get; set; }
        public decimal? Hours3 { get; set; }
        public DateTime? DateWorked4 { get; set; }
        public decimal? Hours4 { get; set; }
        public DateTime? DateWorked5 { get; set; }
        public decimal? Hours5 { get; set; }
        public DateTime? DateWorked6 { get; set; }
        public decimal? Hours6 { get; set; }
        public DateTime? DateWorked7 { get; set; }
        public decimal? Hours7 { get; set; }
        public string EarnTypeFlag { get; set; }
        public int? PayWeekNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CountyPrId { get; set; }
        public string DeptId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PayPeriodId { get; set; }
        public string PayWeekId { get; set; }
        public string TradeId { get; set; }
        public decimal PrevWageRedAmount { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string OtRateRounded { get; set; }

        public Employees Employees { get; set; }
        public Jobs Jobs { get; set; }
    }
}
