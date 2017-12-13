using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PayPeriods
    {
        public PayPeriods()
        {
            EmpPayPeriods = new HashSet<EmpPayPeriods>();
            EqUsage = new HashSet<EqUsage>();
        }

        public int CompanyNo { get; set; }
        public string PayPeriodNo { get; set; }
        public DateTime PeriodStarts { get; set; }
        public DateTime PeriodEnds { get; set; }
        public DateTime CheckDate { get; set; }
        public string PayMethod { get; set; }
        public decimal GlCash { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string PayPeriodId { get; set; }
        public string PiracleAccountNo { get; set; }
        public string PiracleAccountId { get; set; }

        public ICollection<EmpPayPeriods> EmpPayPeriods { get; set; }
        public ICollection<EqUsage> EqUsage { get; set; }
    }
}
