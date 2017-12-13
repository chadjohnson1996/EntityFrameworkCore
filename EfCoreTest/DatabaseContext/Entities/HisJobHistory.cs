using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisJobHistory
    {
        public int CompanyNum { get; set; }
        public int TimecardXref { get; set; }
        public string JobNum { get; set; }
        public string PhaseNum { get; set; }
        public string CostCodeNum { get; set; }
        public string TradeNum { get; set; }
        public string EarnTypeFlag { get; set; }
        public string DeptNum { get; set; }
        public string EarnTypeNum { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Dollars { get; set; }
        public decimal? Fica { get; set; }
        public decimal? UniFringe { get; set; }
        public string CostClassNum { get; set; }
        public decimal? Burden { get; set; }
        public decimal? WorkersComp { get; set; }
        public decimal? Futa { get; set; }
        public decimal? Suta { get; set; }
        public decimal? P401kMatch { get; set; }
        public decimal? Equipment { get; set; }
        public decimal? BurdenToPost { get; set; }
        public decimal? P401kMatchToPost { get; set; }
    }
}
