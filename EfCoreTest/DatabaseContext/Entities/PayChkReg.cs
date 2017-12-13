using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PayChkReg
    {
        public int CompanyNo { get; set; }
        public string PayMethod { get; set; }
        public decimal GlCash { get; set; }
        public int CheckNo { get; set; }
        public string StatusFlag { get; set; }
        public string ReconFlag { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public string LastJobNo { get; set; }
        public int? CheckNumber { get; set; }
        public decimal? CheckAmount { get; set; }
        public DateTime? CheckDate { get; set; }
        public decimal? Fit { get; set; }
        public decimal? Sit { get; set; }
        public decimal? Lit { get; set; }
        public decimal? Fica { get; set; }
        public decimal? Miscellaneous { get; set; }
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
        public decimal? TaxableFringes { get; set; }
        public decimal? TimeoffHoursNotPaid { get; set; }
        public decimal? Medicare { get; set; }
        public string PayoffVoidFlag { get; set; }
        public int? TimecardXref { get; set; }
        public DateTime? DateVoid { get; set; }
        public decimal? P125kDed { get; set; }
        public decimal? NonHourlyQty { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public DateTime? DatePosted { get; set; }
        public decimal? P401kDed { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? VoidTimecardXref { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LastJobId { get; set; }
        public string PayPeriodId { get; set; }
        public DateTime? PrintDate { get; set; }
        public int? DirectDepositBatchNo { get; set; }
        public string DirectDepositBatchId { get; set; }
        public string ThirdParty { get; set; }
        public string ThirdPartyWage { get; set; }
        public string CheckNoSource { get; set; }
        public int ComputeSequence { get; set; }
        public string PaymentGroupNo { get; set; }
        public string TwelfthOfMonthInd { get; set; }
        public DateTime? TwelfthOfMonthDate { get; set; }
        public string PaymentGroupId { get; set; }
        public decimal HsaDeduction { get; set; }
        public string AdjustmentType { get; set; }
        public string AdjustmentPayMethod { get; set; }
        public DateTime? PeriodStarts { get; set; }
        public DateTime? PeriodEnds { get; set; }
        public string CorrectionAllowed { get; set; }
        public int SequenceNo { get; set; }
        public string MostRecentFlag { get; set; }
        public string CorrectionType { get; set; }
        public string NewCheckOption { get; set; }
        public string SequenceId { get; set; }
        public string PrChkStubDtl { get; set; }
        public string PrCheckStubFormat { get; set; }
        public int? PrAuditNumber { get; set; }
        public int? GlTransactionNo { get; set; }
        public string GlTransactionId { get; set; }

        public Employees Employees { get; set; }
        public HisDirectDeposit HisDirectDeposit { get; set; }
    }
}
