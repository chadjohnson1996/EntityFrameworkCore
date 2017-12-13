using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Deductions
    {
        public Deductions()
        {
            DeductionExemptDeductions = new HashSet<DeductionExempt>();
            DeductionExemptDeductionsNavigation = new HashSet<DeductionExempt>();
            DeductionExemptUnion = new HashSet<DeductionExemptUnion>();
            EmpDed = new HashSet<EmpDed>();
            TimecardPaymentGroupDeduction = new HashSet<TimecardPaymentGroupDeduction>();
            UnionEprliveMd = new HashSet<UnionEprliveMd>();
            WcClasses = new HashSet<WcClasses>();
        }

        public int CompanyNo { get; set; }
        public string DeductionNo { get; set; }
        public string Description { get; set; }
        public string ShortDesc { get; set; }
        public string PayCycle { get; set; }
        public decimal DeductHourly { get; set; }
        public decimal Percentage { get; set; }
        public decimal FixedAmount { get; set; }
        public decimal? GlPayable { get; set; }
        public string PercentType { get; set; }
        public string PlanType { get; set; }
        public string SepFlag { get; set; }
        public decimal DeductionLimit { get; set; }
        public string LimitFlag { get; set; }
        public string EarnTypeNo { get; set; }
        public string HourlyType { get; set; }
        public decimal ExemptionPercent { get; set; }
        public decimal ExemptionAmount { get; set; }
        public decimal GarnishLimit { get; set; }
        public string GarnishLimitFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ComputedPlanType { get; set; }
        public string W2Other { get; set; }
        public string CompanyId { get; set; }
        public string DeductionId { get; set; }
        public string EarnTypeId { get; set; }
        public string PercentLimitType { get; set; }
        public string IntegrationType { get; set; }
        public string DefaultInvoiceDate { get; set; }
        public string VendorNo { get; set; }
        public string VendorId { get; set; }
        public string Assoc401kDeductionNo { get; set; }
        public string Assoc401kDeductionId { get; set; }
        public string W2Box12Code { get; set; }
        public string CategoryNo { get; set; }
        public string CategoryId { get; set; }
        public string P4cGarnishmentFlag { get; set; }
        public string FringeBenefit401kType { get; set; }
        public string IncludeInFringeBenefitGroup { get; set; }
        public string ShowMatchingOnStub { get; set; }
        public string QbOverrideDeductionAccountName { get; set; }
        public string QbOverrideDeductionAccountN { get; set; }
        public string ErContribDesc { get; set; }

        public Vendors Vendors { get; set; }
        public P401k P401k { get; set; }
        public ICollection<DeductionExempt> DeductionExemptDeductions { get; set; }
        public ICollection<DeductionExempt> DeductionExemptDeductionsNavigation { get; set; }
        public ICollection<DeductionExemptUnion> DeductionExemptUnion { get; set; }
        public ICollection<EmpDed> EmpDed { get; set; }
        public ICollection<TimecardPaymentGroupDeduction> TimecardPaymentGroupDeduction { get; set; }
        public ICollection<UnionEprliveMd> UnionEprliveMd { get; set; }
        public ICollection<WcClasses> WcClasses { get; set; }
    }
}
