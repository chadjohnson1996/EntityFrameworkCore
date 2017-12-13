using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class WindowSettings
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string WindowName { get; set; }
        public string OpenInAddMode { get; set; }

        public CompanyUser CompanyUser { get; set; }
    }
}
