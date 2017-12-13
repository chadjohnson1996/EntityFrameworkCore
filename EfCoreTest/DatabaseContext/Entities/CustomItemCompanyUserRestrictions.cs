using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CustomItemCompanyUserRestrictions
    {
        public int CustomItemId { get; set; }
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }

        public CompanyUser CompanyUser { get; set; }
        public CustomItems CustomItem { get; set; }
    }
}
