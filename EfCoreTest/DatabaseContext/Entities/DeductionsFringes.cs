using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DeductionsFringes
    {
        public DeductionsFringes()
        {
            DeductionExemptUnion = new HashSet<DeductionExemptUnion>();
            EmpUnionDf = new HashSet<EmpUnionDf>();
            TimecardPaymentGroupDeductionFringe = new HashSet<TimecardPaymentGroupDeductionFringe>();
            UnionDf = new HashSet<UnionDf>();
            UnionEprliveDf = new HashSet<UnionEprliveDf>();
        }

        public int CompanyNo { get; set; }
        public string DeductionFringeNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string PayCycle { get; set; }
        public string AddEarnTypeNo { get; set; }
        public decimal? Limit { get; set; }
        public string LimitType { get; set; }
        public string DeductionFringeFlag { get; set; }
        public string DeductionFringeType { get; set; }
        public string DeductionFringeTaxable { get; set; }
        public string Pension { get; set; }
        public string AddEarnTypeId { get; set; }
        public string CompanyId { get; set; }
        public string DeductionFringeId { get; set; }
        public string IncludeInW2Other { get; set; }
        public string W2OtherType { get; set; }
        public string BenefitTypeNo { get; set; }
        public string BenefitTypeId { get; set; }
        public string EmployerMatchingFlag { get; set; }
        public string Union401KMiscDeduction { get; set; }
        public string ApplyPrevReductionFactor { get; set; }
        public string IncludeInFringeBenefitGroup { get; set; }
        public string W2BenefitType { get; set; }
        public string CalcPerFrgStrTime { get; set; }

        public ICollection<DeductionExemptUnion> DeductionExemptUnion { get; set; }
        public ICollection<EmpUnionDf> EmpUnionDf { get; set; }
        public ICollection<TimecardPaymentGroupDeductionFringe> TimecardPaymentGroupDeductionFringe { get; set; }
        public ICollection<UnionDf> UnionDf { get; set; }
        public ICollection<UnionEprliveDf> UnionEprliveDf { get; set; }
    }
}
