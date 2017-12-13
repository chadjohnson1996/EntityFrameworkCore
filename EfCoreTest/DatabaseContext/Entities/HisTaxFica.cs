using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisTaxFica
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime Dated { get; set; }
        public string PayPeriodNo { get; set; }
        public string PayMethod { get; set; }
        public int TimecardXref { get; set; }
        public decimal? Earnings { get; set; }
        public decimal? Employee { get; set; }
        public decimal? Employer { get; set; }
        public decimal? MedOnlyEarnings { get; set; }
        public decimal? MedEmployee { get; set; }
        public decimal? MedEmployer { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string PayPeriodId { get; set; }
        public string ThirdParty { get; set; }
        public string ThirdPartyWage { get; set; }
        public string TwelfthOfMonthInd { get; set; }
        public DateTime? TwelfthOfMonthDate { get; set; }
        public string HireAct { get; set; }
        public decimal? EmployerCredit { get; set; }
        public decimal MedEmployeeAboveThreshold { get; set; }
        public decimal MedEarningsAboveThreshold { get; set; }

        public Employees Employees { get; set; }
    }
}
