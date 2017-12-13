using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisAccrual
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string AccrualNo { get; set; }
        public int PlanNo { get; set; }
        public DateTime DateBooked { get; set; }
        public string Source { get; set; }
        public int Sequence { get; set; }
        public string PayPeriodNo { get; set; }
        public string PayMethod { get; set; }
        public int? TimecardXref { get; set; }
        public string Type { get; set; }
        public string EarnTypeNo { get; set; }
        public DateTime? PrTransactionDate { get; set; }
        public DateTime? PrCheckDate { get; set; }
        public DateTime? PrDateWeekEnded { get; set; }
        public decimal Hours { get; set; }
        public decimal EligibleHours { get; set; }
        public decimal EligibleEarnings { get; set; }
        public string Comment { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AccrualId { get; set; }
        public string CompanyId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string PayPeriodId { get; set; }
        public string PlanId { get; set; }
        public string IncludeInAnnualLimit { get; set; }
        public string TransferAccrualNo { get; set; }
        public string TransferAccrualId { get; set; }
        public string AccrualBasedOn { get; set; }
        public string AccrualMethod { get; set; }

        public AccrualsD AccrualsD { get; set; }
        public AccrualsH AccrualsH { get; set; }
        public EarnTypes EarnTypes { get; set; }
        public Employees Employees { get; set; }
    }
}
