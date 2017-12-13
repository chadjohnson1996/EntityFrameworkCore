using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CompanyUserProjMgr
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string ProjectManagerNo { get; set; }

        public CompanyUser CompanyUser { get; set; }
        public ProjectManagers ProjectManagers { get; set; }
    }
}
