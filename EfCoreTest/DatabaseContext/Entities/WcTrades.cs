using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class WcTrades
    {
        public int CompanyNo { get; set; }
        public string WcState { get; set; }
        public string TradeNo { get; set; }
        public string Description { get; set; }
        public string WcClassNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string TradeId { get; set; }
        public string WcClassId { get; set; }

        public Trades Trades { get; set; }
        public WcClasses WcClasses { get; set; }
    }
}
