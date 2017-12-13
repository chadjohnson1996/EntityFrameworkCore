using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlConsglCompanies
    {
        public int CompanyNo { get; set; }
        public string DatabaseName { get; set; }
        public int DbCompanyNo { get; set; }
        public string IncludeFlag { get; set; }
        public string PrimaryFlag { get; set; }
        public decimal? DivLevel1 { get; set; }
    }
}
