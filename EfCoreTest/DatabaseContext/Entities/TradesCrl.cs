using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TradesCrl
    {
        public int CompanyNo { get; set; }
        public string TradeNo { get; set; }
        public string Format { get; set; }
        public string CraftCode { get; set; }
        public string LaborCode { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string TradeId { get; set; }

        public Trades Trades { get; set; }
    }
}
