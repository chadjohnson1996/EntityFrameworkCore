using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DropdownSettings
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string DropdownName { get; set; }
        public string DefaultSortColumn { get; set; }
        public string DefaultSortOrder { get; set; }

        public CompanyUser CompanyUser { get; set; }
    }
}
