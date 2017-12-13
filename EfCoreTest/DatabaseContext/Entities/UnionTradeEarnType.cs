using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UnionTradeEarnType
    {
        public UnionTradeEarnType()
        {
            UnionDfAmounts = new HashSet<UnionDfAmounts>();
        }

        public int CompanyNo { get; set; }
        public string UnionNo { get; set; }
        public string TradeNo { get; set; }
        public string EarnTypeNo { get; set; }
        public int? EarnTypeCol { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EarnTypeId { get; set; }
        public string TradeId { get; set; }
        public string UnionId { get; set; }
        public DateTime EffectiveDate { get; set; }

        public UnionTrade UnionTrade { get; set; }
        public ICollection<UnionDfAmounts> UnionDfAmounts { get; set; }
    }
}
