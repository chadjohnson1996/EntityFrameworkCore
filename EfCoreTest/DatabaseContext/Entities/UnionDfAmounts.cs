using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UnionDfAmounts
    {
        public int CompanyNo { get; set; }
        public string UnionNo { get; set; }
        public string TradeNo { get; set; }
        public string DeductionFringeNo { get; set; }
        public string EarnTypeNo { get; set; }
        public decimal? Amount { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeductionFringeId { get; set; }
        public string EarnTypeId { get; set; }
        public string TradeId { get; set; }
        public string UnionId { get; set; }
        public DateTime EffectiveDate { get; set; }

        public UnionDf UnionDf { get; set; }
        public UnionTradeEarnType UnionTradeEarnType { get; set; }
    }
}
