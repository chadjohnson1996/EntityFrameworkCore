using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpUnionTrade
    {
        public EmpUnionTrade()
        {
            EmpUnionDf = new HashSet<EmpUnionDf>();
            EmpUnionTradeEarnType = new HashSet<EmpUnionTradeEarnType>();
        }

        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string UnionNo { get; set; }
        public string TradeNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string Description { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string TradeId { get; set; }
        public string UnionId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public Employees Employees { get; set; }
        public Unions Unions { get; set; }
        public ICollection<EmpUnionDf> EmpUnionDf { get; set; }
        public ICollection<EmpUnionTradeEarnType> EmpUnionTradeEarnType { get; set; }
    }
}
