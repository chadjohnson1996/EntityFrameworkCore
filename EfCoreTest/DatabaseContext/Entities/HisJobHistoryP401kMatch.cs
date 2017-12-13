using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisJobHistoryP401kMatch
    {
        public int CompanyNum { get; set; }
        public int TimecardXref { get; set; }
        public string JobNum { get; set; }
        public string PhaseNum { get; set; }
        public string CostCodeNum { get; set; }
        public string TradeNum { get; set; }
        public string EarnTypeFlag { get; set; }
        public string PayMethod { get; set; }
        public string EarnTypeNum { get; set; }
        public string DeptNum { get; set; }
        public string DedCostCodeNum { get; set; }
        public string DedCostClassNum { get; set; }
        public decimal? Dollars { get; set; }
    }
}
