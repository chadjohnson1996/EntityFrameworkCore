using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PaySummary
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime Dated { get; set; }
        public string PayPeriodNo { get; set; }
        public string PayMethod { get; set; }
        public int LineNo { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public int? CheckNo { get; set; }
        public decimal? CheckAmount { get; set; }
        public DateTime? CheckDate { get; set; }
        public decimal? Fit { get; set; }
        public decimal? Sit { get; set; }
        public decimal? Lit { get; set; }
        public decimal? Fica { get; set; }
        public decimal? Misc { get; set; }
        public decimal? UnionDeductions { get; set; }
        public decimal? UnionFringes { get; set; }
        public decimal? UnionTaxableFringes { get; set; }
        public decimal? RegularHours { get; set; }
        public decimal? OvertimeHours { get; set; }
        public decimal? TimeoffHoursPaid { get; set; }
        public decimal? RegularEarnings { get; set; }
        public decimal? OvertimeEarnings { get; set; }
        public decimal? AdditionalTaxable { get; set; }
        public decimal? AdditionalNonTaxable { get; set; }
        public decimal? TimeoffHoursNotPaid { get; set; }
        public decimal? FitEarnings { get; set; }
        public decimal? SitEarnings { get; set; }
        public decimal? LitEarnings { get; set; }
        public decimal? FicaEarnings { get; set; }
        public decimal? UnionEarnings { get; set; }
        public decimal? Deductions401k { get; set; }
        public decimal? MedicareEarnings { get; set; }
        public decimal? Medicare { get; set; }
        public decimal? Deductions125k { get; set; }
        public decimal? NonHourlyQty { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LineId { get; set; }
        public string PayPeriodId { get; set; }
        public string ThirdParty { get; set; }
        public string ThirdPartyWage { get; set; }
        public string CheckNoSource { get; set; }
        public int ComputeSequence { get; set; }
        public string PaymentGroupNo { get; set; }
        public string PaymentGroupId { get; set; }
        public decimal DeductionsHsa { get; set; }
        public int TimecardXref { get; set; }
        public string PayoffVoidFlag { get; set; }
        public DateTime? PrintDate { get; set; }
        public decimal? TaxableFringes { get; set; }

        public Employees Employees { get; set; }
    }
}
