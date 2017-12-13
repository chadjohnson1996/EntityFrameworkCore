using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PayCrt
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public string JobNo { get; set; }
        public string TradeNo { get; set; }
        public string EarnTypeNo { get; set; }
        public decimal PayRate { get; set; }
        public string PayMethod { get; set; }
        public string DeptNo { get; set; }
        public string CertifiedPayroll { get; set; }
        public string CountyPrNo { get; set; }
        public DateTime? Date1 { get; set; }
        public decimal? Hours1 { get; set; }
        public DateTime? Date2 { get; set; }
        public decimal? Hours2 { get; set; }
        public DateTime? Date3 { get; set; }
        public decimal? Hours3 { get; set; }
        public DateTime? Date4 { get; set; }
        public decimal? Hours4 { get; set; }
        public DateTime? Date5 { get; set; }
        public decimal? Hours5 { get; set; }
        public DateTime? Date6 { get; set; }
        public decimal? Hours6 { get; set; }
        public DateTime? Date7 { get; set; }
        public decimal? Hours7 { get; set; }
        public decimal? JobWages { get; set; }
        public decimal? JobAdd { get; set; }
        public string FicaFlag { get; set; }
        public string FitFlag { get; set; }
        public string SitFlag { get; set; }
        public string LitFlag { get; set; }
        public string UniDedFlag { get; set; }
        public string EarnTypeFlag { get; set; }
        public string PrevailFlag { get; set; }
        public decimal? FringeAmt { get; set; }
        public decimal? TaxFringeAmt { get; set; }
        public int PayWeekNo { get; set; }
        public string PostFlag { get; set; }
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
        public string PayPeriodId { get; set; }
        public string PayWeekId { get; set; }
        public string TradeId { get; set; }
        public decimal? PrevWageRedAmount { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int ComputeSequence { get; set; }
        public string OtRateRounded { get; set; }

        public Employees Employees { get; set; }
    }
}
