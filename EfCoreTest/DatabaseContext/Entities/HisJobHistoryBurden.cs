using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisJobHistoryBurden
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
        public int BurdenNum { get; set; }
        public decimal? BurdenDollars { get; set; }
        public string BurdenCostClassNum { get; set; }
        public string BurdenCostCodeNum { get; set; }
    }
}
