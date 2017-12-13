using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UnionTradesBrdHdr
    {
        public UnionTradesBrdHdr()
        {
            UnionTradesBrd = new HashSet<UnionTradesBrd>();
        }

        public int CompanyNo { get; set; }
        public string UnionNo { get; set; }
        public string TradeNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string Description { get; set; }
        public string CompanyId { get; set; }
        public string TradeId { get; set; }
        public string UnionId { get; set; }

        public Unions Unions { get; set; }
        public ICollection<UnionTradesBrd> UnionTradesBrd { get; set; }
    }
}
