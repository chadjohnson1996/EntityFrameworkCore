using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisSumGeneral
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string Year { get; set; }
        public decimal? Net { get; set; }
        public DateTime? LastUpdate { get; set; }
        public decimal? Fit { get; set; }
        public decimal? Sit { get; set; }
        public decimal? Lit { get; set; }
        public decimal? FicaEmployee { get; set; }
        public decimal? FicaEmployer { get; set; }
        public decimal? FitEarnings { get; set; }
        public decimal? FicaEarnings { get; set; }
        public decimal? UnionFringes { get; set; }
        public decimal? UnionTaxableFringes { get; set; }
        public decimal? RegularHours { get; set; }
        public decimal? OvertimeHours { get; set; }
        public decimal? TimeoffHoursPaid { get; set; }
        public decimal? TimeoffHoursNotPaid { get; set; }
        public decimal? RegularEarnings { get; set; }
        public decimal? OvertimeEarnings { get; set; }
        public decimal? AdditionalTaxable { get; set; }
        public decimal? AdditionalNonTaxable { get; set; }
        public decimal? TaxableFringes { get; set; }
        public decimal? MedicareEmployee { get; set; }
        public decimal? MedicareEmployer { get; set; }
        public decimal? MedicareEarnings { get; set; }
        public decimal? FutaEligible { get; set; }
        public decimal? FutaBase { get; set; }
        public decimal? FutaAmount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public decimal FicaEmployerCredit { get; set; }
        public decimal MedEmployeeAboveThreshold { get; set; }
        public decimal MedEarningsAboveThreshold { get; set; }

        public Employees Employees { get; set; }
    }
}
