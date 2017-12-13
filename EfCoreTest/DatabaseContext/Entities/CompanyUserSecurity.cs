using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CompanyUserSecurity
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public int EnableFlag { get; set; }
        public string SecuredItemType { get; set; }
        public int SecuredItemId { get; set; }

        public CompanyUser CompanyUser { get; set; }
    }
}
