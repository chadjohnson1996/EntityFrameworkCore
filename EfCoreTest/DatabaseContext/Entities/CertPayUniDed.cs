using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CertPayUniDed
    {
        public DateTime TimestampIdentifier { get; set; }
        public int CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string JobId { get; set; }
        public string TradeId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime DateWeekEnded { get; set; }
        public string DeductionFringeId { get; set; }
        public decimal DeductionAmountThisWeek { get; set; }
    }
}
