using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UnionTradesRates
    {
        public int CompanyNo { get; set; }
        public string UnionNo { get; set; }
        public string TradeNo { get; set; }
        public string ShiftNo { get; set; }
        public decimal PayRate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string CompanyId { get; set; }
        public string ShiftId { get; set; }
        public string TradeId { get; set; }
        public string UnionId { get; set; }

        public UnionShiftRt UnionShiftRt { get; set; }
    }
}
