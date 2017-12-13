using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpUnionTradeEarnType
    {
        public EmpUnionTradeEarnType()
        {
            EmpUnionDfAmounts = new HashSet<EmpUnionDfAmounts>();
        }

        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string UnionNo { get; set; }
        public string TradeNo { get; set; }
        public string EarnTypeNo { get; set; }
        public int? EarnTypeCol { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string TradeId { get; set; }
        public string UnionId { get; set; }
        public DateTime EffectiveDate { get; set; }

        public EmpUnionTrade EmpUnionTrade { get; set; }
        public ICollection<EmpUnionDfAmounts> EmpUnionDfAmounts { get; set; }
    }
}
