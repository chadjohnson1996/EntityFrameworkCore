using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CustomItemCompanyRestrictions
    {
        public int CustomItemId { get; set; }
        public int CompanyNo { get; set; }

        public CustomItems CustomItem { get; set; }
    }
}
