using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UnionDf
    {
        public UnionDf()
        {
            UnionDfAmounts = new HashSet<UnionDfAmounts>();
            UnionTradesPerc = new HashSet<UnionTradesPerc>();
        }

        public int CompanyNo { get; set; }
        public string UnionNo { get; set; }
        public string TradeNo { get; set; }
        public string DeductionFringeNo { get; set; }
        public string DeductionFringeFlag { get; set; }
        public string DeductionFringeType { get; set; }
        public string DeductionFringeTaxable { get; set; }
        public string PayCycle { get; set; }
        public string AddEarnTypeNo { get; set; }
        public decimal Limit { get; set; }
        public string LimitType { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AddEarnTypeId { get; set; }
        public string CompanyId { get; set; }
        public string DeductionFringeId { get; set; }
        public string TradeId { get; set; }
        public string UnionId { get; set; }
        public string FringeDedWholeHours { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string UseCap { get; set; }
        public decimal? CapRate { get; set; }
        public string CalcPerFrgStrTime { get; set; }

        public DeductionsFringes DeductionsFringes { get; set; }
        public EarnTypes EarnTypes { get; set; }
        public UnionTrade UnionTrade { get; set; }
        public ICollection<UnionDfAmounts> UnionDfAmounts { get; set; }
        public ICollection<UnionTradesPerc> UnionTradesPerc { get; set; }
    }
}
