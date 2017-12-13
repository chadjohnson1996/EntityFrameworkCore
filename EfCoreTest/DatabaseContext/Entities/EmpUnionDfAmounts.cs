using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpUnionDfAmounts
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string UnionNo { get; set; }
        public string TradeNo { get; set; }
        public string DeductionFringeNo { get; set; }
        public string EarnTypeNo { get; set; }
        public decimal? Amount { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeductionFringeId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string TradeId { get; set; }
        public string UnionId { get; set; }
        public DateTime EffectiveDate { get; set; }

        public EmpUnionDf EmpUnionDf { get; set; }
        public EmpUnionTradeEarnType EmpUnionTradeEarnType { get; set; }
    }
}
