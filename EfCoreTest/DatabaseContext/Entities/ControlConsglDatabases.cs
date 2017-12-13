using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlConsglDatabases
    {
        public int CompanyNo { get; set; }
        public string DatabaseName { get; set; }
        public string ServerDbName { get; set; }
        public string IncludeFlag { get; set; }
        public string ServerName { get; set; }
    }
}
