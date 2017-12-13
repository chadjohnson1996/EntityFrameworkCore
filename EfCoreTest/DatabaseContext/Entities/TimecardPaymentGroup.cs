using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TimecardPaymentGroup
    {
        public TimecardPaymentGroup()
        {
            TcRecurTypes = new HashSet<TcRecurTypes>();
            TimeCards = new HashSet<TimeCards>();
            TimecardPaymentGroupDeduction = new HashSet<TimecardPaymentGroupDeduction>();
            TimecardPaymentGroupDeductionFringe = new HashSet<TimecardPaymentGroupDeductionFringe>();
        }

        public int CompanyNo { get; set; }
        public string PaymentGroupNo { get; set; }
        public int ComputeSequence { get; set; }
        public string PayMethod { get; set; }
        public string DefaultPaymentGroup { get; set; }
        public string ComputeMiscDeductions { get; set; }
        public string ComputeUniDedFrg { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string Description { get; set; }
        public string CompanyId { get; set; }
        public string PaymentGroupId { get; set; }
        public string FedTaxOption { get; set; }
        public decimal? FedTaxFixedRate { get; set; }
        public string StateTaxOption { get; set; }
        public decimal? StateTaxFixedRate { get; set; }
        public string LocalTaxOption { get; set; }
        public decimal? LocalTaxFixedRate { get; set; }

        public ICollection<TcRecurTypes> TcRecurTypes { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
        public ICollection<TimecardPaymentGroupDeduction> TimecardPaymentGroupDeduction { get; set; }
        public ICollection<TimecardPaymentGroupDeductionFringe> TimecardPaymentGroupDeductionFringe { get; set; }
    }
}
