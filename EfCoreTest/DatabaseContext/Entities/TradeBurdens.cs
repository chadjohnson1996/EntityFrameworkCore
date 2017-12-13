using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TradeBurdens
    {
        public int CompanyNo { get; set; }
        public string TradeNo { get; set; }
        public int BurdenNo { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? Limit { get; set; }
        public decimal? GlExpense { get; set; }
        public decimal? GlPayable { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BurdenId { get; set; }
        public string CompanyId { get; set; }
        public string TradeId { get; set; }
        public string Excluded { get; set; }

        public Trades Trades { get; set; }
    }
}
