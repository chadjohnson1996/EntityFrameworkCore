using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PayGen
    {
        public int CompanyNo { get; set; }
        public string PayPeriodNo { get; set; }
        public string EmployeeNo { get; set; }
        public string PayMethod { get; set; }
        public string LastJobNo { get; set; }
        public string ErrorFlag { get; set; }
        public string StatusFlag { get; set; }
        public int? CheckNo { get; set; }
        public decimal? CheckAmt { get; set; }
        public DateTime? CheckDate { get; set; }
        public decimal? Fit { get; set; }
        public decimal? Sit { get; set; }
        public decimal? Lit { get; set; }
        public decimal? Fica { get; set; }
        public decimal? Misc { get; set; }
        public decimal? UnionDeduction { get; set; }
        public decimal? UnionFringe { get; set; }
        public decimal? UnionTaxableFringe { get; set; }
        public decimal? RegHours { get; set; }
        public decimal? OvtHours { get; set; }
        public decimal? TimeOffHrsPaid { get; set; }
        public decimal? TimeOffHrsNotPaid { get; set; }
        public decimal? RegEarnings { get; set; }
        public decimal? OvtEarnings { get; set; }
        public decimal? AdditionalTaxable { get; set; }
        public decimal? AdditionalNonTaxable { get; set; }
        public decimal? TaxableFringe { get; set; }
        public decimal? P401kDeduction { get; set; }
        public decimal? Medicare { get; set; }
        public string PayoffVoidFlag { get; set; }
        public int? VoidXrefNo { get; set; }
        public decimal? P125kDeduction { get; set; }
        public decimal? NonHourlyQty { get; set; }
        public string AdjustFlag { get; set; }
        public string PostFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LastJobId { get; set; }
        public string PayPeriodId { get; set; }
        public string VoidXrefId { get; set; }
        public string ThirdParty { get; set; }
        public string ThirdPartyWage { get; set; }
        public string PaymentGroupNo { get; set; }
        public int ComputeSequence { get; set; }
        public string TwelfthOfMonthInd { get; set; }
        public DateTime? TwelfthOfMonthDate { get; set; }
        public string PaymentGroupId { get; set; }
        public decimal HsaDeduction { get; set; }
        public string AdjustmentType { get; set; }
        public string AdjustmentPayMethod { get; set; }
        public DateTime? PeriodStarts { get; set; }
        public DateTime? PeriodEnds { get; set; }
        public string CorrectionType { get; set; }
        public string NewCheckOption { get; set; }
        public string PrChkStubDtl { get; set; }
        public string PrCheckStubFormat { get; set; }

        public Employees Employees { get; set; }
    }
}
