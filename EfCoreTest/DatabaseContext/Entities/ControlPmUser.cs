using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlPmUser
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string FlPromptUnpostedEq { get; set; }
        public string FlPromptUnpostedIn { get; set; }

        public CompanyUser CompanyUser { get; set; }
    }
}
